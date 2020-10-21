using BarleyBreak.Models;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BarleyBreak.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private readonly Random rand = new Random();
        private readonly List<string> initializated = new List<string>();
        private readonly ReferenceCollection<GroundCell> cellList = new ReferenceCollection<GroundCell>(16);

        private bool isGameStarted = false;
        private int moves = 0;

        private readonly GroundCell cell1 = new GroundCell(1, "1").CanMoveRight().CanMoveDown();
        private readonly GroundCell cell2 = new GroundCell(2, "2").CanMoveLeft().CanMoveRight().CanMoveDown();
        private readonly GroundCell cell3 = new GroundCell(3, "3").CanMoveLeft().CanMoveRight().CanMoveDown();
        private readonly GroundCell cell4 = new GroundCell(4, "4").CanMoveLeft().CanMoveDown();
        private readonly GroundCell cell5 = new GroundCell(5, "5").CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell6 = new GroundCell(6, "6").CanMoveLeft().CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell7 = new GroundCell(7, "7").CanMoveLeft().CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell8 = new GroundCell(8, "8").CanMoveLeft().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell9 = new GroundCell(9, "9").CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell10 = new GroundCell(10, "10").CanMoveLeft().CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell11 = new GroundCell(11, "11").CanMoveLeft().CanMoveRight().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell12 = new GroundCell(12, "12").CanMoveLeft().CanMoveUp().CanMoveDown();
        private readonly GroundCell cell13 = new GroundCell(13, "13").CanMoveRight().CanMoveUp();
        private readonly GroundCell cell14 = new GroundCell(14, "14").CanMoveLeft().CanMoveRight().CanMoveUp();
        private readonly GroundCell cell15 = new GroundCell(15, "15").CanMoveLeft().CanMoveRight().CanMoveUp();
        private readonly GroundCell cell16 = new GroundCell(16, "").CanMoveLeft().CanMoveUp();

        #region public cells
        public GroundCell Cell1
        {
            get
            {
                return cellList[0];
            }
            set
            {
                cellList[0] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell2
        {
            get
            {
                return cellList[1];
            }
            set
            {
                cellList[1] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell3
        {
            get
            {
                return cellList[2];
            }
            set
            {
                cellList[2] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell4
        {
            get
            {
                return cellList[3];
            }
            set
            {
                cellList[3] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell5
        {
            get
            {
                return cellList[4];
            }
            set
            {
                cellList[4] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell6
        {
            get
            {
                return cellList[5];
            }
            set
            {
                cellList[5] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell7
        {
            get
            {
                return cellList[6];
            }
            set
            {
                cellList[6] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell8
        {
            get
            {
                return cellList[7];
            }
            set
            {
                cellList[7] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell9
        {
            get
            {
                return cellList[8];
            }
            set
            {
                cellList[8] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell10
        {
            get
            {
                return cellList[9];
            }
            set
            {
                cellList[9] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell11
        {
            get
            {
                return cellList[10];
            }
            set
            {
                cellList[10] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell12
        {
            get
            {
                return cellList[11];
            }
            set
            {
                cellList[11] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell13
        {
            get
            {
                return cellList[12];
            }
            set
            {
                cellList[12] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell14
        {
            get
            {
                return cellList[13];
            }
            set
            {
                cellList[13] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell15
        {
            get
            {
                return cellList[14];
            }
            set
            {
                cellList[14] = value;
                OnPropertyChanged();
            }
        }
        public GroundCell Cell16
        {
            get
            {
                return cellList[15];
            }
            set
            {
                cellList[15] = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public int Moves
        {
            get
            {
                return moves;
            }
            set
            {
                moves = value;
                OnPropertyChanged();
                OnPropertyChanged("MovesString");
            }
        }
        public string MovesString => $"Moves: {Moves}";

        public ICommand StartGameCommand => new Command(InitGame);
        public ICommand CellCommand => new Command(cell => MoveCell((GroundCell)cell));

        public MainViewModel()
        {
            cellList.AddReference(ref cell1);
            cellList.AddReference(ref cell2);
            cellList.AddReference(ref cell3);
            cellList.AddReference(ref cell4);
            cellList.AddReference(ref cell5);
            cellList.AddReference(ref cell6);
            cellList.AddReference(ref cell7);
            cellList.AddReference(ref cell8);
            cellList.AddReference(ref cell9);
            cellList.AddReference(ref cell10);
            cellList.AddReference(ref cell11);
            cellList.AddReference(ref cell12);
            cellList.AddReference(ref cell13);
            cellList.AddReference(ref cell14);
            cellList.AddReference(ref cell15);
            cellList.AddReference(ref cell16);
        }

        private async void InitGame()
        {
            try
            {
                bool answer = await Application.Current.MainPage.DisplayAlert("New game", "Do you want start new game?", "Yes", "No");
                if (answer)
                {
                    Moves = 0;

                    GenerateRandomGrid();
                    UpdateGrid();
                    isGameStarted = true;
                }
            }
            catch
            {
                isGameStarted = false;
                await Application.Current.MainPage.DisplayAlert("ERROR", "Uncknown error", "Cancel");
            }
        }
        private void GenerateRandomGrid()
        {
            bool generatedDone = false;
            GenerateAllValues();

            while (!generatedDone)
            {
                int sum = 0;

                for (int i = 0; i < 15; i++)
                {
                    for (int j = i + 1; j <= 15; j++)
                    {
                        if(int.TryParse(cellList[i].Value, out int mainCell) &&
                           int.TryParse(cellList[j].Value, out int compareCell) &&
                           mainCell > compareCell)
                        {
                            sum++;
                        }
                    }
                }

                if (sum % 2 == 0)
                {
                    generatedDone = true;
                }
                else
                {
                    GenerateAllValues();
                }
            }
        }
        private void GenerateAllValues()
        {
            Cell1.Value = GetRandomValue();
            Cell2.Value = GetRandomValue();
            Cell3.Value = GetRandomValue();
            Cell4.Value = GetRandomValue();
            Cell5.Value = GetRandomValue();
            Cell6.Value = GetRandomValue();
            Cell7.Value = GetRandomValue();
            Cell8.Value = GetRandomValue();
            Cell9.Value = GetRandomValue();
            Cell10.Value = GetRandomValue();
            Cell11.Value = GetRandomValue();
            Cell12.Value = GetRandomValue();
            Cell13.Value = GetRandomValue();
            Cell14.Value = GetRandomValue();
            Cell15.Value = GetRandomValue();
            Cell16.Value = GetRandomValue();

            initializated.Clear();
        }
        private string GetRandomValue()
        {
            var result = GetCellString(rand.Next(0, 16));
            while (initializated.Contains(result))
            {
                result = GetCellString(rand.Next(0, 16));
            }

            initializated.Add(result);
            return result;
        }
        private string GetCellString(int value)
        {
            if (value == 0)
            {
                return "";
            }
            else
            {
                return value.ToString();
            }
        }

        private void MoveCell(GroundCell cell)
        {
            if (isGameStarted)
            {
                if (cell.Value == "")
                {
                    return;
                }
                if (cell.Variants.HaveTopAction && cellList[cell.Place - 5].Value == "")
                {
                    cellList[cell.Place - 5].Value = cell.Value;
                    cell.Value = "";
                    UpdateGrid();
                    Moves++;
                }
                else if (cell.Variants.HaveLeftAction && cellList[cell.Place - 2].Value == "")
                {
                    cellList[cell.Place - 2].Value = cell.Value;
                    cell.Value = "";
                    UpdateGrid();
                    Moves++;
                }
                else if (cell.Variants.HaveRightAction && cellList[cell.Place].Value == "")
                {
                    cellList[cell.Place].Value = cell.Value;
                    cell.Value = "";
                    UpdateGrid();
                    Moves++;
                }
                else if (cell.Variants.HaveBottomAction && cellList[cell.Place + 3].Value == "")
                {
                    cellList[cell.Place + 3].Value = cell.Value;
                    cell.Value = "";
                    UpdateGrid();
                    Moves++;
                }
            }
        }
        private void UpdateGrid()
        {
            for (int i = 1; i <= 16; i++)
            {
                OnPropertyChanged("Cell" + i);
            }
            WinCondition();
        }
        private async void WinCondition()
        {
            for (int i = 0; i <= 14; i++)
            {
                if (cellList[i].Value == (i + 1).ToString())
                {
                    continue;
                }
                else
                {
                    return;
                }
            }

            isGameStarted = false;

            bool answer = await Application.Current.MainPage.DisplayAlert("Well done!", $"You won with {moves} moves. Do you want start and win again?", "New game", "Cancel");
            if (answer)
            {
                InitGame();
            }
        }
    }
}
