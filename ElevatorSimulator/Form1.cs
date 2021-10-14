using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSimulator
{
    public partial class Form1 : Form
    {
        string[] floors = new string[2] { "GroundFloor", "Floor1" };
        string liftLocation = "";
        bool liftMoving = false;
        bool dataTableContainsData = false;
        private DataSet dataSet = new DataSet();
        private string dbconnection;
        private string dbcommand;
        private OleDbConnection connection;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;
        DataTable dataTable;

        public Form1()
        {
            Random random = new Random();
            liftLocation = floors[random.Next(floors.Length)];
            InitializeComponent();
            if (liftLocation == floors[0])
            {
                LiftPicturebox.Location = new Point(101, 235);
            }
            else
            {
                LiftPicturebox.Location = new Point(101, 52);
            }
        }

        public void InsertRow(string action, bool InsertRows)
        {
            if (dbconnection == null)
            {
                OpenConnection();
                loadDBintoDataSet();
                SetDataTable();
                CloseConnection();
            }
            AddDataRowToDataSet(action, InsertRows);
            UpdateLog(true);
        }

        public void Display()
        {
            if (dbconnection == null)
            {
                OpenConnection();
                loadDBintoDataSet();
                SetDataTable();
                CloseConnection();
            }
            else
            {
                if (logLst.Items.Count != 0)
                {
                    InsertRowsIntoDB();
                }
            }
            UpdateLog(false);
        }

        public void UpdateLog(bool addSingleRow)
        {
            if (addSingleRow == true)
            {
                DataRow lastRow = dataTable.Rows[dataTable.Rows.Count - 1];
                logLst.Items.Add(lastRow["LiftCommand"] + " (" + lastRow["CommandDateTime"] + ")");
            }
            else
            {
                logLst.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    logLst.Items.Add(row["LiftCommand"] + " (" + row["CommandDateTime"] + ")");
                }
            }
        }

        bool displayLogClicked = false;

        public void CloseConnection()
        {
            connection.Close();
        }

        public void OpenConnection()
        {
            try
            {
                dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source=../../../db/ElevatorSimulatorLogDB.accdb";
                dbcommand = "SELECT *FROM ELEVATORLOG;";
                connection = new OleDbConnection(dbconnection);
                comm = new OleDbCommand(dbcommand, connection);
                adapter = new OleDbDataAdapter(comm);
                builder = new OleDbCommandBuilder(adapter);
                dataSet = new DataSet();
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadDBintoDataSet()
        {
            adapter.Fill(dataSet, "LOG");
        }

        
        public void SetDataTable()
        {
            dataTableContainsData = true;
            dataTable = dataSet.Tables[0];
        }

        public void AddDataRowToDataSet(string command, bool insertintoDb)
        {
            if (dataTableContainsData == false)
            {
                SetDataTable();
            }
            DataRow newRow = dataSet.Tables[0].NewRow();
            newRow["LiftID"] = dataTable.Rows.Count.ToString();
            newRow["LiftCommand"] = command;
            newRow["CommandDateTime"] = DateTime.Now;
            dataSet.Tables[0].Rows.Add(newRow);
            if (insertintoDb == true)
            {
                InsertRowsIntoDB();
            }
        }

        public void InsertRowsIntoDB()
        {
                 
            if (dataSet.Tables[0].Rows.Count != 0)       
            {
                try
                {
                    DataSet dataSetChanges = dataSet.GetChanges();
                    adapter.Update(dataSetChanges, "LOG");
                    dataSet.Tables[0].AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            if (displayLogClicked == true)
            {
                UpdateLog(false);  
            }
       
        }

        private void LiftDownBtn_Click(object sender, EventArgs e)
        {
            if (liftLocation != floors[0])
            {
                InsertRow("Lift Going Down", false);
                OpenDoorTimer.Enabled = false;
                MoveLiftDownTimer.Enabled = true;
            }
            else
            {
                OpenDoorTimer.Enabled = true;
            }
        }

        private void CloseDoorBtn_Click(object sender, EventArgs e)
        {
            OpenDoorTimer.Enabled = false;
            CloseDoorTimer.Enabled = true;
        }

        public void closeDoor(PictureBox leftdoor, PictureBox rightDoor)
        {
            if (leftdoor.Left != 101)
            {
                rightDoor.Left -= 1;
                leftdoor.Left += 1;
            }
            else
            {
                CloseDoorTimer.Enabled = false;
            }
        }

        private void CloseDoorTimer_Tick(object sender, EventArgs e)
        {
            switch (liftLocation)
            {
                case "GroundFloor":
                    closeDoor(GroundFloorLeftDoor, GroundFloorRightDoor);
                    break;
                case "Floor1":
                    closeDoor(level1leftDoor, level1RightDoor);
                    break;
                default:
                    throw new Exception("Lift location unknown");
            }
            EnableAllButtons();
        }

        public void DisableAllbuttonExcept(Button buttonName)
        {
            CloseDoorBtn.Enabled = false;
            OpenDoorBtn.Enabled = false;
            LiftUpBtn.Enabled = false;
            LiftDownBtn.Enabled = false;
            Level1btn.Enabled = false;
            GroundFloorbtn.Enabled = false;
            buttonName.Enabled = true;
        }

        public void DisableAllButtons()
        {
            CloseDoorBtn.Enabled = false;
            OpenDoorBtn.Enabled = false;
            LiftUpBtn.Enabled = false;
            LiftDownBtn.Enabled = false;
            Level1btn.Enabled = false;
            GroundFloorbtn.Enabled = false;
        }

        public void EnableAllButtons()
        {
            CloseDoorBtn.Enabled = true;
            OpenDoorBtn.Enabled = true;
            LiftUpBtn.Enabled = true;
            LiftDownBtn.Enabled = true;
            Level1btn.Enabled = true;
            GroundFloorbtn.Enabled = true;
        }

        public void opendoor(PictureBox leftDoor, PictureBox rightDoor, int doorVal)
        {
            if (leftDoor.Left != doorVal)
            {
                rightDoor.Left += 1;
                leftDoor.Left -= 1;
            }
            else
            {
                if (liftMoving != true)
                {
                    OpenDoorTimer.Enabled = false;
                    DisableAllbuttonExcept(CloseDoorBtn);
                    DateTime dtTwoSeconds = DateTime.Now.AddSeconds(2);
                    while (dtTwoSeconds > DateTime.Now)
                    {

                    }
                    CloseDoorTimer.Enabled = true;
                }
            }
        }

        private void OpenDoorTimer_Tick(object sender, EventArgs e)
        {
            switch (liftLocation)
            {
                case "GroundFloor":
                    opendoor(GroundFloorLeftDoor, GroundFloorRightDoor, 12);
                    break;
                case "Floor1":
                    opendoor(level1leftDoor, level1RightDoor, 12);
                    break;
                default:
                    throw new Exception("Lift location unknown");
            }
        }

        private void OpenDoorBtn_Click(object sender, EventArgs e)
        {
            OpenDoorTimer.Enabled = true;
        }

        private void MoveLiftDownTimer_Tick(object sender, EventArgs e)
        {
            switch (liftLocation)
            {
                case "GroundFloor":
                    break;
                case "Floor1":
                    DisableAllButtons();
                    closeDoor(level1leftDoor, level1RightDoor);
                    if (LiftPicturebox.Top != 236)
                    {
                        liftMoving = true;
                        LiftPicturebox.Top += 1;
                    }
                    else
                    {
                        liftMoving = false;
                        MoveLiftDownTimer.Enabled = false;
                        liftLocation = floors[0];
                        OpenDoorTimer.Enabled = true;
                    }
                    break;
                default:
                    throw new Exception("Lift location unknown");
            }
        }

        private void LiftUpBtn_Click(object sender, EventArgs e)
        {
            if (liftLocation != floors[1])
            {
                InsertRow("Lift Going Up", false);
                MoveLiftUpTimer.Enabled = true;
            }
            else
            {
                OpenDoorTimer.Enabled = true;
            }
        }

        private void MoveLiftUpTimer_Tick(object sender, EventArgs e)
        {
            switch (liftLocation)
            {
                case "GroundFloor":
                    DisableAllButtons();
                    if (LiftPicturebox.Top != 52)
                    {
                        liftMoving = true;
                        LiftPicturebox.Top -= 1;
                    }
                    else
                    {
                        liftMoving = false;
                        MoveLiftUpTimer.Enabled = false;
                        liftLocation = floors[1];
                        OpenDoorTimer.Enabled = true;
                    }
                    break;
                case "Floor1":
                    break;
                default:
                    throw new Exception("Lift location unknown");
            }
        }

        private void GroundFloorbtn_Click(object sender, EventArgs e)
        {
            if (liftLocation == floors[1])
            {
                InsertRow("Lift Going Down", false);
                MoveLiftDownTimer.Enabled = true;
            }
            else
            {
                OpenDoorTimer.Enabled = true;
            }
        }

        private void Level1btn_Click(object sender, EventArgs e)
        {
            if (liftLocation == floors[0])
            {
                InsertRow("Lift Going Up", false);
                MoveLiftUpTimer.Enabled = true;
            }
            else
            {
                OpenDoorTimer.Enabled = true;
            }
        }

        private void DisplayLogbtn_Click(object sender, EventArgs e)
        {
            Display();
        }

        private void ClearLogbtn_Click(object sender, EventArgs e)
        {
            logLst.Items.Clear();
        }
    }
}