//Skeleton Program code for the AQA A Level Paper 1 Summer 2021 examination
//this code should be used in conjunction with the Preliminary Material
//written by the AQA Programmer Team
//developed in the Visual Studio Community Edition programming environment

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HexBaronCS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fileLoaded = true;
            Player player1, player2;
            HexGrid grid;
            string choice = "";
            while (choice != "Q")
            {
                DisplayMainMenu();
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    SetUpDefaultGame(out player1, out player2, out grid);
                    PlayGame(player1, player2, grid);
                }
                else if (choice == "2")
                {
                    fileLoaded = LoadGame(out player1, out player2, out grid);
                    if (fileLoaded)
                        PlayGame(player1, player2, grid);
                }
            }
        }

        public static bool LoadGame(out Player player1, out Player player2, out HexGrid grid)
        {
            Console.Write("Enter the name of the file to load: ");
            string fileName = Console.ReadLine();
            List<string> items;
            string lineFromFile;
            try
            {
                using (StreamReader myStream = new StreamReader(fileName))
                {
                    lineFromFile = myStream.ReadLine();
                    items = lineFromFile.Split(',').ToList();
                    player1 = new Player(items[0], Convert.ToInt32(items[1]), Convert.ToInt32(items[2]), Convert.ToInt32(items[3]), Convert.ToInt32(items[4]));
                    lineFromFile = myStream.ReadLine();
                    items = lineFromFile.Split(',').ToList();
                    player2 = new Player(items[0], Convert.ToInt32(items[1]), Convert.ToInt32(items[2]), Convert.ToInt32(items[3]), Convert.ToInt32(items[4]));
                    int gridSize = Convert.ToInt32(myStream.ReadLine());
                    grid = new HexGrid(gridSize);
                    List<string> t = new List<string>(myStream.ReadLine().Split(','));
                    grid.SetUpGridTerrain(t);
                    lineFromFile = myStream.ReadLine();
                    while (lineFromFile != null)
                    {
                        items = lineFromFile.Split(',').ToList();
                        if (items[0] == "1")
                        {
                            grid.AddPiece(true, items[1], Convert.ToInt32(items[2]));
                        }
                        else
                        {
                            grid.AddPiece(false, items[1], Convert.ToInt32(items[2]));
                        }
                        lineFromFile = myStream.ReadLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("File not loaded");
                player1 = new Player("", 0, 0, 0, 0);
                player2 = new Player("", 0, 0, 0, 0);
                grid = new HexGrid(0);
                return false;
            }
            return true;
        }

        public static void SetUpDefaultGame(out Player player1, out Player player2, out HexGrid grid)
        {
            List<string> t = new List<string>() {" ", "#", "#", " ", "~", "~", " ", " ", " ", "~", " ", "#", "#", " ", " ", " "
                                                 , " ", " ", "#", "#", "#", "#", "~", "~", "~", "~", "~", " ", "#", " ", "#", " "};
            int gridSize = 8;
            grid = new HexGrid(gridSize);
            player1 = new Player("Player One", 0, 10, 10, 5);
            player2 = new Player("Player Two", 1, 10, 10, 5);
            grid.SetUpGridTerrain(t);
            grid.AddPiece(true, "Baron", 0);
            grid.AddPiece(true, "Serf", 8);
            grid.AddPiece(false, "Baron", 31);
            grid.AddPiece(false, "Serf", 23);
        }

        public static bool CheckMoveCommandFormat(List<string> items)
        {
            int result;
            if (items.Count == 3)
            {
                for (var count = 1; count <= 2; count++)
                {
                    try
                    {
                        result = Convert.ToInt32(items[count]);
                    }
                    catch
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static bool CheckStandardCommandFormat(List<string> items)
        {
            int result;
            if (items.Count == 2)
            {
                try
                {
                    result = Convert.ToInt32(items[1]);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool CheckUpgradeCommandFormat(List<string> items)
        {
            int result;
            if (items.Count == 3)
            {
                if (items[1].ToUpper() != "LESS" && items[1].ToUpper() != "PBDS")
                    return false;
                try
                {
                    result = Convert.ToInt32(items[2]);
                }
                catch
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static bool CheckCommandIsValid(List<string> items)
        {
            if (items.Count > 0)
            {
                switch (items[0])
                {
                    case "move":
                        {
                            return CheckMoveCommandFormat(items);
                        }

                    case "dig":
                    case "saw":
                    case "spawn":
                        {
                            return CheckStandardCommandFormat(items);
                        }

                    case "upgrade":
                        {
                            return CheckUpgradeCommandFormat(items);
                        }
                }
            }
            return false;
        }

        public static void PlayGame(Player player1, Player player2, HexGrid grid)
        {
            bool gameOver = false;
            bool player1Turn = true;
            bool validCommand;
            List<string> commands = new List<string>();
            Console.WriteLine("Player One current state - " + player1.GetStateString());
            Console.WriteLine("Player Two current state - " + player2.GetStateString());
            do
            {
                Console.WriteLine(grid.GetGridAsString(player1Turn));
                if (player1Turn)
                    Console.WriteLine(player1.GetName() + " state your three commands, pressing enter after each one.");
                else
                    Console.WriteLine(player2.GetName() + " state your three commands, pressing enter after each one.");
                for (int count = 1; count <= 3; count++)
                {
                    Console.Write("Enter command: ");
                    commands.Add(Console.ReadLine().ToLower());
                }
                foreach (var c in commands)
                {
                    List<string> items = new List<string>(c.Split(' '));
                    validCommand = CheckCommandIsValid(items);
                    if (!validCommand)
                        Console.WriteLine("Invalid command");
                    else
                    {
                        int fuelChange = 0;
                        int lumberChange = 0;
                        int supplyChange = 0;
                        string summaryOfResult;
                        if (player1Turn)
                        {
                            summaryOfResult = grid.ExecuteCommand(items, ref fuelChange, ref lumberChange, ref supplyChange,
                                player1.GetFuel(), player1.GetLumber(), player1.GetPiecesInSupply());
                            player1.UpdateLumber(lumberChange);
                            player1.UpdateFuel(fuelChange);
                            if (supplyChange == 1)
                                player1.RemoveTileFromSupply();
                        }
                        else
                        {
                            summaryOfResult = grid.ExecuteCommand(items, ref fuelChange, ref lumberChange, ref supplyChange,
                                player2.GetFuel(), player2.GetLumber(), player2.GetPiecesInSupply());
                            player2.UpdateLumber(lumberChange);
                            player2.UpdateFuel(fuelChange);
                            if (supplyChange == 1)
                            {
                                player2.RemoveTileFromSupply();
                            }
                        }
                        Console.WriteLine(summaryOfResult);
                    }
                }

                commands.Clear();
                player1Turn = !player1Turn;
                int player1VPsGained = 0;
                int player2VPsGained = 0;
                if (gameOver)
                {
                    grid.DestroyPiecesAndCountVPs(ref player1VPsGained, ref player2VPsGained);
                }
                else
                    gameOver = grid.DestroyPiecesAndCountVPs(ref player1VPsGained, ref player2VPsGained);
                player1.AddToVPs(player1VPsGained);
                player2.AddToVPs(player2VPsGained);
                Console.WriteLine("Player One current state - " + player1.GetStateString());
                Console.WriteLine("Player Two current state - " + player2.GetStateString());
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }
            while (!gameOver || !player1Turn);
            Console.WriteLine(grid.GetGridAsString(player1Turn));
            DisplayEndMessages(player1, player2);
        }

        public static void DisplayEndMessages(Player player1, Player player2)
        {
            Console.WriteLine();
            Console.WriteLine(player1.GetName() + " final state: " + player1.GetStateString());
            Console.WriteLine();
            Console.WriteLine(player2.GetName() + " final state: " + player2.GetStateString());
            Console.WriteLine();
            if (player1.GetVPs() > player2.GetVPs())
            {
                Console.WriteLine(player1.GetName() + " is the winner!");
            }
            else
            {
                Console.WriteLine(player2.GetName() + " is the winner!");
            }
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("1. Default game");
            Console.WriteLine("2. Load game");
            Console.WriteLine("Q. Quit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
        }
    }

    class Piece
    {
        protected bool destroyed, belongsToPlayer1;
        protected int fuelCostOfMove, VPValue, connectionsToDestroy;
        protected string pieceType;

        public Piece(bool player1)
        {
            fuelCostOfMove = 1;
            belongsToPlayer1 = player1;
            destroyed = false;
            pieceType = "S";
            VPValue = 1;
            connectionsToDestroy = 2;
        }

        public virtual int GetVPs()
        {
            return VPValue;
        }

        public virtual bool GetBelongsToPlayer1()
        {
            return belongsToPlayer1;
        }

        public virtual int CheckMoveIsValid(int distanceBetweenTiles, string startTerrain, string endTerrain)
        {
            if (distanceBetweenTiles == 1)
            {
                if (startTerrain == "~" || endTerrain == "~")
                {
                    return fuelCostOfMove * 2;
                }
                else
                {
                    return fuelCostOfMove;
                }
            }
            return -1;
        }

        public virtual bool HasMethod(string methodName)
        {
            return this.GetType().GetMethod(methodName) != null;
        }

        public virtual int GetConnectionsNeededToDestroy()
        {
            return connectionsToDestroy;
        }

        public virtual string GetPieceType()
        {
            if (belongsToPlayer1)
            {
                return pieceType;
            }
            else
            {
                return pieceType.ToLower();
            }
        }

        public virtual void DestroyPiece()
        {
            destroyed = true;
        }
    }

    class BaronPiece : Piece
    {
        public BaronPiece(bool player1)
            : base(player1)
        {
            pieceType = "B";
            VPValue = 10;
        }

        public override int CheckMoveIsValid(int distanceBetweenTiles, string startTerrain, string endTerrain)
        {
            if (distanceBetweenTiles == 1)
            {
                return fuelCostOfMove;
            }
            return -1;
        }
    }

    class LESSPiece : Piece
    {
        public LESSPiece(bool player1)
            : base(player1)
        {
            pieceType = "L";
            VPValue = 3;
        }

        public override int CheckMoveIsValid(int distanceBetweenTiles, string startTerrain, string endTerrain)
        {
            if (distanceBetweenTiles == 1 && startTerrain != "#")
            {
                if (startTerrain == "~" || endTerrain == "~")
                {
                    return fuelCostOfMove * 2;
                }
                else
                {
                    return fuelCostOfMove;
                }

            }
            return -1;
        }

        public int Saw(string terrain)
        {
            if (terrain != "#")
            {
                return 0;
            }
            return 1;
        }

    }

    class PBDSPiece : Piece
    {
        static Random rNoGen = new Random();

        public PBDSPiece(bool player1)
            : base(player1)
        {
            pieceType = "P";
            VPValue = 2;
            fuelCostOfMove = 2;
        }

        public override int CheckMoveIsValid(int distanceBetweenTiles, string startTerrain, string endTerrain)
        {
            if (distanceBetweenTiles != 1 || startTerrain == "~")
            {
                return -1;
            }
            return fuelCostOfMove;
        }

        public int Dig(string terrain)
        {
            if (terrain != "~")
            {
                return 0;
            }
            if (rNoGen.NextDouble() < 0.9)
            {
                return 1;
            }
            else
            {
                return 5;
            }
        }
    }

    class Tile
    {
        protected string terrain;
        protected int x, y, z;
        protected Piece pieceInTile;
        protected List<Tile> neighbours = new List<Tile>();

        public Tile(int xcoord, int ycoord, int zcoord)
        {
            x = xcoord;
            y = ycoord;
            z = zcoord;
            terrain = " ";
            pieceInTile = null;
        }

        public int GetDistanceToTileT(Tile t)
        {
            return Math.Max(Math.Max(Math.Abs(Getx() - t.Getx()), Math.Abs(Gety() - t.Gety())), Math.Abs(Getz() - t.Getz()));
        }

        public void AddToNeighbours(Tile n)
        {
            neighbours.Add(n);
        }

        public List<Tile> GetNeighbours()
        {
            return neighbours;
        }

        public void SetPiece(Piece thePiece)
        {
            pieceInTile = thePiece;
        }

        public void SetTerrain(string t)
        {
            terrain = t;
        }

        public int Getx()
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }

        public int Getz()
        {
            return z;
        }

        public string GetTerrain()
        {
            return terrain;
        }

        public Piece GetPieceInTile()
        {
            return pieceInTile;
        }
    }

    class HexGrid
    {
        protected List<Tile> tiles = new List<Tile>();
        protected List<Piece> pieces = new List<Piece>();
        int size;
        bool player1Turn;

        public HexGrid(int n)
        {
            size = n;
            SetUpTiles();
            SetUpNeighbours();
            player1Turn = true;
        }

        public void SetUpGridTerrain(List<string> listOfTerrain)
        {
            for (int count = 0; count < listOfTerrain.Count; count++)
            {
                tiles[count].SetTerrain(listOfTerrain[count]);
            }
        }

        public void AddPiece(bool belongsToPlayer1, string typeOfPiece, int location)
        {
            Piece newPiece;
            if (typeOfPiece == "Baron")
            {
                newPiece = new BaronPiece(belongsToPlayer1);
            }
            else if (typeOfPiece == "LESS")
            {
                newPiece = new LESSPiece(belongsToPlayer1);
            }
            else if (typeOfPiece == "PBDS")
            {
                newPiece = new PBDSPiece(belongsToPlayer1);
            }
            else
            {
                newPiece = new Piece(belongsToPlayer1);
            }
            pieces.Add(newPiece);
            tiles[location].SetPiece(newPiece);
        }

        public string ExecuteCommand(List<string> items, ref int fuelChange, ref int lumberChange,
                                     ref int supplyChange, int fuelAvailable, int lumberAvailable,
                                     int piecesInSupply)
        {
            switch (items[0])
            {
                case "move":
                    {
                        int fuelCost = ExecuteMoveCommand(items, fuelAvailable);
                        if (fuelCost < 0)
                        {
                            return "That move can't be done";
                        }
                        fuelChange = -fuelCost;
                        break;
                    }
                case "saw":
                case "dig":
                    {
                        if (!ExecuteCommandInTile(items, ref fuelChange, ref lumberChange))
                        {
                            return "Couldn't do that";
                        }
                        break;
                    }
                case "spawn":
                    {
                        int lumberCost = ExecuteSpawnCommand(items, lumberAvailable, piecesInSupply);
                        if (lumberCost < 0)
                            return "Spawning did not occur";
                        lumberChange = -lumberCost;
                        supplyChange = 1;
                        break;
                    }
                case "upgrade":
                    {
                        int lumberCost = ExecuteUpgradeCommand(items, lumberAvailable);
                        if (lumberCost < 0)
                            return "Upgrade not possible";
                        lumberChange = -lumberCost;
                        break;
                    }
            }
            return "Command executed";
        }

        private bool CheckTileIndexIsValid(int tileToCheck)
        {
            return tileToCheck >= 0 && tileToCheck < tiles.Count;
        }

        private bool CheckPieceAndTileAreValid(int tileToUse)
        {
            if (CheckTileIndexIsValid(tileToUse))
            {
                Piece thePiece = tiles[tileToUse].GetPieceInTile();
                if (thePiece != null)
                {
                    if (thePiece.GetBelongsToPlayer1() == player1Turn)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ExecuteCommandInTile(List<string> items, ref int fuel, ref int lumber)
        {
            int tileToUse = Convert.ToInt32(items[1]);
            if (CheckPieceAndTileAreValid(tileToUse) == false)
            {
                return false;
            }
            Piece thePiece = tiles[tileToUse].GetPieceInTile();
            items[0] = items[0][0].ToString().ToUpper() + items[0].Substring(1);
            if (thePiece.HasMethod(items[0]))
            {
                string methodToCall = items[0];
                Type t = thePiece.GetType();
                System.Reflection.MethodInfo method = t.GetMethod(methodToCall);
                object[] parameters = { tiles[tileToUse].GetTerrain() };
                if (items[0] == "Saw")
                {
                    lumber += Convert.ToInt32(method.Invoke(thePiece, parameters));
                }
                else if (items[0] == "Dig")
                {
                    fuel += Convert.ToInt32(method.Invoke(thePiece, parameters));
                    if (Math.Abs(fuel) > 2)
                    {
                        tiles[tileToUse].SetTerrain(" ");
                    }
                }
                return true;
            }
            return false;
        }

        private int ExecuteMoveCommand(List<string> items, int fuelAvailable)
        {
            int startID = Convert.ToInt32(items[1]);
            int endID = Convert.ToInt32(items[2]);
            if (!CheckPieceAndTileAreValid(startID) || !CheckTileIndexIsValid(endID))
            {
                return -1;
            }
            Piece thePiece = tiles[startID].GetPieceInTile();
            if (tiles[endID].GetPieceInTile() != null)
            {
                return -1;
            }
            int distance = tiles[startID].GetDistanceToTileT(tiles[endID]);
            int fuelCost = thePiece.CheckMoveIsValid(distance, tiles[startID].GetTerrain(), tiles[endID].GetTerrain());
            if (fuelCost == -1 || fuelAvailable < fuelCost)
            {
                return -1;
            }
            MovePiece(endID, startID);
            return fuelCost;
        }

        private int ExecuteSpawnCommand(List<string> items, int lumberAvailable, int piecesInSupply)
        {
            int tileToUse = Convert.ToInt32(items[1]);
            if (piecesInSupply < 1 || lumberAvailable < 3 || !CheckTileIndexIsValid(tileToUse))
            {
                return -1;
            }
            Piece ThePiece = tiles[tileToUse].GetPieceInTile();
            if (ThePiece != null)
            {
                return -1;
            }
            bool ownBaronIsNeighbour = false;
            List<Tile> listOfNeighbours = new List<Tile>(tiles[tileToUse].GetNeighbours());
            foreach (var n in listOfNeighbours)
            {
                ThePiece = n.GetPieceInTile();
                if (ThePiece != null)
                {
                    if (player1Turn && ThePiece.GetPieceType() == "B" || !player1Turn && ThePiece.GetPieceType() == "b")
                    {
                        ownBaronIsNeighbour = true;
                        break;
                    }
                }
            }
            if (!ownBaronIsNeighbour)
            {
                return -1;
            }
            Piece newPiece = new Piece(player1Turn);
            pieces.Add(newPiece);
            tiles[tileToUse].SetPiece(newPiece);
            return 3;
        }

        private int ExecuteUpgradeCommand(List<string> items, int lumberAvailable)
        {
            int tileToUse = Convert.ToInt32(items[2]);
            if (!CheckPieceAndTileAreValid(tileToUse) || lumberAvailable < 5 || !(items[1] == "pbds" || items[1] == "less"))
            {
                return -1;
            }
            else
            {
                Piece thePiece = tiles[tileToUse].GetPieceInTile();
                if (thePiece.GetPieceType().ToUpper() != "S")
                {
                    return -1;
                }
                thePiece.DestroyPiece();
                if (items[1] == "pbds")
                {
                    thePiece = new PBDSPiece(player1Turn);
                }
                else
                {
                    thePiece = new LESSPiece(player1Turn);
                }
                pieces.Add(thePiece);
                tiles[tileToUse].SetPiece(thePiece);
                return 5;
            }
        }

        private void SetUpTiles()
        {
            int evenStartY = 0;
            int evenStartZ = 0;
            int oddStartZ = 0;
            int oddStartY = -1;
            int x, y, z;
            for (int count = 1; count <= size / 2; count++)
            {
                y = evenStartY;
                z = evenStartZ;
                for (x = 0; x <= size - 2; x += 2)
                {
                    Tile tempTile = new Tile(x, y, z);
                    tiles.Add(tempTile);
                    y -= 1;
                    z -= 1;
                }
                evenStartZ += 1;
                evenStartY -= 1;
                y = oddStartY;
                z = oddStartZ;
                for (x = 1; x <= size - 1; x += 2)
                {
                    Tile tempTile = new Tile(x, y, z);
                    tiles.Add(tempTile);
                    y -= 1;
                    z -= 1;
                }
                oddStartZ += 1;
                oddStartY -= 1;
            }
        }

        private void SetUpNeighbours()
        {
            foreach (var fromTile in tiles)
            {
                foreach (var toTile in tiles)
                {
                    if (fromTile.GetDistanceToTileT(toTile) == 1)
                    {
                        fromTile.AddToNeighbours(toTile);
                    }
                }
            }
        }

        public bool DestroyPiecesAndCountVPs(ref int player1VPs, ref int player2VPs)
        {
            bool baronDestroyed = false;
            List<Tile> listOfTilesContainingDestroyedPieces = new List<Tile>();
            foreach (var t in tiles)
            {
                if (t.GetPieceInTile() != null)
                {
                    List<Tile> listOfNeighbours = new List<Tile>(t.GetNeighbours());
                    int noOfConnections = 0;
                    foreach (var n in listOfNeighbours)
                    {
                        if (n.GetPieceInTile() != null)
                        {
                            noOfConnections += 1;
                        }
                    }
                    Piece thePiece = t.GetPieceInTile();
                    if (noOfConnections >= thePiece.GetConnectionsNeededToDestroy())
                    {
                        thePiece.DestroyPiece();
                        if (thePiece.GetPieceType().ToUpper() == "B")
                            baronDestroyed = true;
                        listOfTilesContainingDestroyedPieces.Add(t);
                        if (thePiece.GetBelongsToPlayer1())
                        {
                            player2VPs += thePiece.GetVPs();
                        }
                        else
                        {
                            player1VPs += thePiece.GetVPs();
                        }
                    }
                }
            }
            foreach (var t in listOfTilesContainingDestroyedPieces)
            {
                t.SetPiece(null);
            }
            return baronDestroyed;
        }

        public string GetGridAsString(bool p1Turn)
        {
            int listPositionOfTile = 0;
            player1Turn = p1Turn;
            string gridAsString = CreateTopLine() + CreateEvenLine(true, ref listPositionOfTile);
            listPositionOfTile += 1;
            gridAsString += CreateOddLine(ref listPositionOfTile);
            for (var count = 1; count <= size - 2; count += 2)
            {
                listPositionOfTile += 1;
                gridAsString += CreateEvenLine(false, ref listPositionOfTile);
                listPositionOfTile += 1;
                gridAsString += CreateOddLine(ref listPositionOfTile);
            }
            return gridAsString + CreateBottomLine();
        }

        private void MovePiece(int newIndex, int oldIndex)
        {
            tiles[newIndex].SetPiece(tiles[oldIndex].GetPieceInTile());
            tiles[oldIndex].SetPiece(null);
        }

        public string GetPieceTypeInTile(int ID)
        {
            Piece thePiece = tiles[ID].GetPieceInTile();
            if (thePiece == null)
            {
                return " ";
            }
            else
            {
                return thePiece.GetPieceType();
            }
        }

        private string CreateBottomLine()
        {
            string line = "   ";
            for (var count = 1; count <= size / 2; count++)
            {
                line += @" \__/ ";
            }
            return line + Environment.NewLine;
        }

        private string CreateTopLine()
        {
            string line = Environment.NewLine + "  ";
            for (var count = 1; count <= size / 2; count++)
            {
                line += "__    ";
            }
            return line + Environment.NewLine;
        }

        private string CreateOddLine(ref int listPositionOfTile)
        {
            string line = "";
            for (var count = 1; count <= size / 2; count++)
            {
                if (count > 1 & count < size / 2)
                {
                    line += GetPieceTypeInTile(listPositionOfTile) + @"\__/";
                    listPositionOfTile += 1;
                    line += tiles[listPositionOfTile].GetTerrain();
                }
                else if (count == 1)
                {
                    line += @" \__/" + tiles[listPositionOfTile].GetTerrain();
                }
            }
            line += GetPieceTypeInTile(listPositionOfTile) + @"\__/";
            listPositionOfTile += 1;
            if (listPositionOfTile < tiles.Count())
            {
                line += tiles[listPositionOfTile].GetTerrain() + GetPieceTypeInTile(listPositionOfTile) + @"\" + Environment.NewLine;
            }
            else
            {
                line += @"\" + Environment.NewLine;
            }
            return line;
        }

        private string CreateEvenLine(bool firstEvenLine, ref int listPositionOfTile)
        {
            string line = " /" + tiles[listPositionOfTile].GetTerrain();
            for (var count = 1; count <= size / 2 - 1; count++)
            {
                line += GetPieceTypeInTile(listPositionOfTile);
                listPositionOfTile += 1;
                line += @"\__/" + tiles[listPositionOfTile].GetTerrain();
            }
            if (firstEvenLine)
            {
                line += GetPieceTypeInTile(listPositionOfTile) + @"\__" + Environment.NewLine;
            }
            else
            {
                line += GetPieceTypeInTile(listPositionOfTile) + @"\__/" + Environment.NewLine;
            }
            return line;
        }
    }

    class Player
    {
        protected int piecesInSupply, fuel, VPs, lumber;
        protected string name;

        public Player(string n, int v, int f, int l, int t)
        {
            name = n;
            VPs = v;
            fuel = f;
            lumber = l;
            piecesInSupply = t;
        }

        public virtual string GetStateString()
        {
            return "VPs: " + VPs.ToString() + "   Pieces in supply: " + piecesInSupply.ToString() + "   Lumber: " + lumber.ToString() + "   Fuel: " + fuel.ToString();
        }

        public virtual int GetVPs()
        {
            return VPs;
        }

        public virtual int GetFuel()
        {
            return fuel;
        }

        public virtual int GetLumber()
        {
            return lumber;
        }

        public virtual string GetName()
        {
            return name;
        }

        public virtual void AddToVPs(int n)
        {
            VPs += n;
        }

        public virtual void UpdateFuel(int n)
        {
            fuel += n;
        }

        public virtual void UpdateLumber(int n)
        {
            lumber += n;
        }

        public int GetPiecesInSupply()
        {
            return piecesInSupply;
        }

        public virtual void RemoveTileFromSupply()
        {
            piecesInSupply -= 1;
        }
    }
}
