using BarleyBreak.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BarleyBreak.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private readonly Easing progressEasing = Easing.BounceIn;
        private readonly Random rand = new Random();
        private readonly List<string> initializated = new List<string>();
        private readonly ReferenceCollection<GroundCell> cellList = new ReferenceCollection<GroundCell>(16);

        private bool isGameStarted = false;
        private ProgressBar progressBar = new ProgressBar();
        private bool isBusy = false;
        private string busyProgressString;
        private int moves = 0;

        private readonly GroundCell cell1 = new GroundCell(1, "1", false, false, true, true);
        private readonly GroundCell cell2 = new GroundCell(2, "2", false, true, true, true);
        private readonly GroundCell cell3 = new GroundCell(3, "3", false, true, true, true);
        private readonly GroundCell cell4 = new GroundCell(4, "4", false, true, false, true);
        private readonly GroundCell cell5 = new GroundCell(5, "5", true, false, true, true);
        private readonly GroundCell cell6 = new GroundCell(6, "6", true, true, true, true);
        private readonly GroundCell cell7 = new GroundCell(7, "7", true, true, true, true);
        private readonly GroundCell cell8 = new GroundCell(8, "8", true, true, false, true);
        private readonly GroundCell cell9 = new GroundCell(9, "9", true, false, true, true);
        private readonly GroundCell cell10 = new GroundCell(10, "10", true, true, true, true);
        private readonly GroundCell cell11 = new GroundCell(11, "11", true, true, true, true);
        private readonly GroundCell cell12 = new GroundCell(12, "12", true, true, false, true);
        private readonly GroundCell cell13 = new GroundCell(13, "13", true, false, true, false);
        private readonly GroundCell cell14 = new GroundCell(14, "14", true, true, true, false);
        private readonly GroundCell cell15 = new GroundCell(15, "15", true, true, true, false);
        private readonly GroundCell cell16 = new GroundCell(16, "", true, true, false, false);

        public ProgressBar ProgressBar
        {
            get
            {
                return progressBar;
            }
            set
            {
                progressBar = value;
                OnPropertyChanged();
            }
        }

        public string BusyTitle => "Loading new game";

        public string BusyProgressString
        {
            get
            {
                return busyProgressString;
            }
            set
            {
                busyProgressString = value;
                OnPropertyChanged();
            }
        }

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

        public bool IsBusy
        {
            get
            {
                return isBusy;
            }
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }

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

        public ICommand StartGameCommand { get; }

        #region cells command
        public ICommand Cell1Command { get; }
        public ICommand Cell2Command { get; }
        public ICommand Cell3Command { get; }
        public ICommand Cell4Command { get; }
        public ICommand Cell5Command { get; }
        public ICommand Cell6Command { get; }
        public ICommand Cell7Command { get; }
        public ICommand Cell8Command { get; }
        public ICommand Cell9Command { get; }
        public ICommand Cell10Command { get; }
        public ICommand Cell11Command { get; }
        public ICommand Cell12Command { get; }
        public ICommand Cell13Command { get; }
        public ICommand Cell14Command { get; }
        public ICommand Cell15Command { get; }
        public ICommand Cell16Command { get; }
        #endregion

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

            StartGameCommand = new Command(InitGame);

            Cell1Command = new Command(Cell1Action);
            Cell2Command = new Command(Cell2Action);
            Cell3Command = new Command(Cell3Action);
            Cell4Command = new Command(Cell4Action);
            Cell5Command = new Command(Cell5Action);
            Cell6Command = new Command(Cell6Action);
            Cell7Command = new Command(Cell7Action);
            Cell8Command = new Command(Cell8Action);
            Cell9Command = new Command(Cell9Action);
            Cell10Command = new Command(Cell10Action);
            Cell11Command = new Command(Cell11Action);
            Cell12Command = new Command(Cell12Action);
            Cell13Command = new Command(Cell13Action);
            Cell14Command = new Command(Cell14Action);
            Cell15Command = new Command(Cell15Action);
            Cell16Command = new Command(Cell16Action);
        }

        private async void InitGame()
        {
            try
            {
                bool responce = await Application.Current.MainPage.DisplayAlert("New game", "Do you want start new game?", "Yes", "Cancel");
                if (responce)
                {
                    await Task.Run(async () =>
                    {
                        Moves = 0;
                        IsBusy = true;
                        progressBar.Progress = 0;
                        BusyProgressString = "0/16 loaded.";

                        Cell1 = new GroundCell(cell1.Place, InitUnit(), cell1.Variants);
                        await this.ProgressBar.ProgressTo(1 / 16d, 10, progressEasing);
                        BusyProgressString = "1/16 loaded.";

                        Cell2 = new GroundCell(cell2.Place, InitUnit(), cell2.Variants);
                        await this.ProgressBar.ProgressTo(2 / 16d, 10, progressEasing);
                        BusyProgressString = "2/16 loaded.";

                        Cell3 = new GroundCell(cell3.Place, InitUnit(), cell3.Variants);
                        await this.ProgressBar.ProgressTo(3 / 16d, 10, progressEasing);
                        BusyProgressString = "3/16 loaded.";

                        Cell4 = new GroundCell(cell4.Place, InitUnit(), cell4.Variants);
                        await this.ProgressBar.ProgressTo(4 / 16d, 10, progressEasing);
                        BusyProgressString = "4/16 loaded.";

                        Cell5 = new GroundCell(cell5.Place, InitUnit(), cell5.Variants);
                        await this.ProgressBar.ProgressTo(5 / 16d, 10, progressEasing);
                        BusyProgressString = "5/16 loaded.";

                        Cell6 = new GroundCell(cell6.Place, InitUnit(), cell6.Variants);
                        await this.ProgressBar.ProgressTo(6 / 16d, 10, progressEasing);
                        BusyProgressString = "6/16 loaded.";

                        Cell7 = new GroundCell(cell7.Place, InitUnit(), cell7.Variants);
                        await this.ProgressBar.ProgressTo(7 / 16d, 10, progressEasing);
                        BusyProgressString = "7/16 loaded.";

                        Cell8 = new GroundCell(cell8.Place, InitUnit(), cell8.Variants);
                        await this.ProgressBar.ProgressTo(8 / 16d, 10, progressEasing);
                        BusyProgressString = "8/16 loaded.";

                        Cell9 = new GroundCell(cell9.Place, InitUnit(), cell9.Variants);
                        await this.ProgressBar.ProgressTo(9 / 16d, 10, progressEasing);
                        BusyProgressString = "9/16 loaded.";

                        Cell10 = new GroundCell(cell10.Place, InitUnit(), cell10.Variants);
                        await this.ProgressBar.ProgressTo(10 / 16d, 10, progressEasing);
                        BusyProgressString = "10/16 loaded.";

                        Cell11 = new GroundCell(cell11.Place, InitUnit(), cell11.Variants);
                        await this.ProgressBar.ProgressTo(11 / 16d, 10, progressEasing);
                        BusyProgressString = "11/16 loaded.";

                        Cell12 = new GroundCell(cell12.Place, InitUnit(), cell12.Variants);
                        await this.ProgressBar.ProgressTo(12 / 16d, 10, progressEasing);
                        BusyProgressString = "12/16 loaded.";

                        Cell13 = new GroundCell(cell13.Place, InitUnit(), cell13.Variants);
                        await this.ProgressBar.ProgressTo(13 / 16d, 10, progressEasing);
                        BusyProgressString = "13/16 loaded.";

                        Cell14 = new GroundCell(cell14.Place, InitUnit(), cell14.Variants);
                        await this.ProgressBar.ProgressTo(14 / 16d, 10, progressEasing);
                        BusyProgressString = "14/16 loaded.";

                        Cell15 = new GroundCell(cell15.Place, InitUnit(), cell15.Variants);
                        await this.ProgressBar.ProgressTo(15 / 16d, 10, progressEasing);
                        BusyProgressString = "15/16 loaded.";

                        Cell16 = new GroundCell(cell16.Place, InitUnit(), cell16.Variants);
                        await this.ProgressBar.ProgressTo(1, 10, progressEasing);
                        BusyProgressString = "16/16 loaded.";

                        initializated.Clear();
                        isGameStarted = true;
                        IsBusy = false;
                    });
                }
            }
            catch
            {
                IsBusy = false;
                isGameStarted = false;
                await Application.Current.MainPage.DisplayAlert("ERROR", "Uncknown error", "Cancel");
            }
        }

        private string InitUnit()
        {
            var result = GetString(rand.Next(0, 16));
            if (initializated.Contains(result))
            {
                return InitUnit();
            }
            else
            {
                initializated.Add(result);
                return result;
            }
        }

        private string GetString(int value)
        {
            string result;

            if (value == 0) result = "";
            else result = value.ToString();

            return result;
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
            Cell1 = cellList[0];
            Cell2 = cellList[1];
            Cell3 = cellList[2];
            Cell4 = cellList[3];
            Cell5 = cellList[4];
            Cell6 = cellList[5];
            Cell7 = cellList[6];
            Cell8 = cellList[7];
            Cell9 = cellList[8];
            Cell10 = cellList[9];
            Cell11 = cellList[10];
            Cell12 = cellList[11];
            Cell13 = cellList[12];
            Cell14 = cellList[13];
            Cell15 = cellList[14];
            Cell16 = cellList[15];
            WinCondition();
        }

        private async void WinCondition()
        {
            for (int i = 0; i < 14; i++)
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

            bool responce = await Application.Current.MainPage.DisplayAlert("Well done!", $"You won with {moves} moves. Do you want start and win again?", "New game", "Cancel");

            if (responce)
            {
                InitGame();
            }
        }

        private void Cell1Action() => MoveCell(Cell1);
        private void Cell2Action() => MoveCell(Cell2);
        private void Cell3Action() => MoveCell(Cell3);
        private void Cell4Action() => MoveCell(Cell4);
        private void Cell5Action() => MoveCell(Cell5);
        private void Cell6Action() => MoveCell(Cell6);
        private void Cell7Action() => MoveCell(Cell7);
        private void Cell8Action() => MoveCell(Cell8);
        private void Cell9Action() => MoveCell(Cell9);
        private void Cell10Action() => MoveCell(Cell10);
        private void Cell11Action() => MoveCell(Cell11);
        private void Cell12Action() => MoveCell(Cell12);
        private void Cell13Action() => MoveCell(Cell13);
        private void Cell14Action() => MoveCell(Cell14);
        private void Cell15Action() => MoveCell(Cell15);
        private void Cell16Action() => MoveCell(Cell16);
    }
}
