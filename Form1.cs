using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Data.Sql;

namespace ProblemRegistration
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=GOLD-PEN\SQLEXPRESSMES;Initial Catalog = MES_Project; Integrated Security = True; Timeout = 5");
        SqlDataAdapter adpt;
        DataTable tb;
        public Form1()
        {
            UseWaitCursor = true;
            InitializeComponent();
            try
            {

                UseWaitCursor = true;
                showDept();
                showEquipTeam();
                showPlans();
            }
            catch
            {
                UseWaitCursor = false;
                MessageBox.Show("Can't connect to Databases", "Connection problem");
                Environment.Exit(0);
            }
            UseWaitCursor = false;
            lbPlans.Visible = false;
            lPart.Visible = false;
            //lbEqTeam.Visible = false;
            // lbDept.Visible = false;
            lbEmployee.Visible = false;
            lbEqList.Visible = false;
            lbEqPart.Visible = false;
            lbEqPoint.Visible = false;
            lbSensor.Visible = false;
            txtDescription.Visible = false;
            lTeam.Visible = false;
            //lDept.Visible = false;
            lEmployee.Visible = false;
            lList.Visible = false;
            lPart.Visible = false;
            lPoint.Visible = false;
            lSensor.Visible = false;
            lDescription.Visible = false;
            lCreated.Visible = false;
            lbCreated.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataPickerUpdt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataPickerUpdt();
        }

        void DataPickerUpdt()
        {
            datepicker.Format = DateTimePickerFormat.Custom;
            datepicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }
        void showPlans()
        {
            adpt = new SqlDataAdapter("SELECT top (9) [Plan] FROM WorkStatusSCH WHERE Status = 'Start' ORDER BY DataUpdate DESC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            foreach (DataRow ro in tb.Rows)
            {
                lbPlans.Items.Add(ro["Plan"].ToString());
            }
        }
        void showDept()
        {
            adpt = new SqlDataAdapter("SELECT ID, Department as Dept FROM PersonalDepartment ORDER BY Dept ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            foreach (DataRow ro in tb.Rows)
            {
                lbDept.Items.Add(ro["Dept"].ToString());
            }
            lbDept.Items.Add("Все");
        }
        void showEquipTeam()
        {
            string Column = "Name";
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentTeam ORDER BY " + Column + " ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            foreach (DataRow ro in tb.Rows)
            {
                lbEqTeam.Items.Add(ro[Column].ToString());
            }
        }
        void showEployee(int ID)
        {
            adpt = new SqlDataAdapter("SELECT ID, Employee, DeptID FROM PersonalEmployee WHERE DeptID =" + ID + " ORDER BY Employee  ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbEmployee.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbEmployee.Items.Add(ro["Employee"].ToString());
            }
        }
        void showEployee()
        {
            adpt = new SqlDataAdapter("SELECT ID, Employee, DeptID FROM PersonalEmployee ORDER BY Employee  ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbEmployee.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbEmployee.Items.Add(ro["Employee"].ToString());
            }
        }
        private int WhatIsIDDept(string employee)
        {
            adpt = new SqlDataAdapter("SELECT ID, Department FROM PersonalDepartment WHERE Department = '" + employee + "'", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            string k = "";
            int id;
            k = tb.Rows[0]["ID"].ToString();
            return id = Convert.ToInt32(k);
        }
        private int SortTeamList(string Equip)
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentTeam WHERE Name = '" + Equip + "'", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            string k = "";
            int id;
            k = tb.Rows[0]["ID"].ToString();
            return id = Convert.ToInt32(k);
        }
        private int SortListList(string Equip)
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentList WHERE Equipment = '" + Equip + "'", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            string k = "";
            int id;
            k = tb.Rows[0]["ID"].ToString();
            return id = Convert.ToInt32(k);
        }
        private int SortListPart(string Equip)
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentPart WHERE PartName = '" + Equip + "'", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            string k = "";
            int id;
            k = tb.Rows[0]["ID"].ToString();
            return id = Convert.ToInt32(k);
        }
        private void lbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employee = lbDept.SelectedItem.ToString();
            lbEmployee.Visible = true;
            lEmployee.Visible = true;
            if (employee == "Все")
            {
                showEployee();
            }
            else
            {
                int ID = WhatIsIDDept(employee);
                showEployee(ID);
            }
        }
        private void lbEqTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbPlans.Visible = true;
            lPlan.Visible = true;
            lbDept.Visible = true;
            lDept.Visible = true;
            lbSensor.Visible = false;
            lbEqPart.Visible = false;
            lSensor.Visible = false;
            lPart.Visible = false;
            lbEqPart.Items.Clear();
            lbEqPoint.Visible = false;
            lPoint.Visible = false;
            lbEqPoint.Items.Clear();
            lbEqList.Visible = true;
            lList.Visible = true;
            txtDescription.Visible = true;
            lDescription.Visible = true;
            string eq = lbEqTeam.SelectedItem.ToString();
            int ID = SortTeamList(eq);
            showEquip(ID);
        }
        private void lbEqList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSensor.Visible = false;
            lbEqPoint.Visible = false;
            lSensor.Visible = false;
            lPoint.Visible = false;
            lbEqPoint.Items.Clear();
            lbEqPart.Visible = true;
            lPart.Visible = true;
            string eq = lbEqList.SelectedItem.ToString();
            int ID = SortListList(eq);
            showParts(ID);
        }
        private void lbEqPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEqPart.SelectedItem.ToString() == "інше")
            {
                lbSensor.Visible = false;
                lbEqPoint.Visible = false;
                lSensor.Visible = false;
                lPoint.Visible = false;
                return;
            }
            lbSensor.Visible = false;
            lbEqPoint.Visible = true;
            lSensor.Visible = false;
            lPoint.Visible = true;
            string eq = lbEqPart.SelectedItem.ToString();
            int ID = SortListPart(eq);
            showPoints(ID);
        }
        void showEquip(int ID)
        {
            string Name = "Equipment";
            adpt = new SqlDataAdapter("SELECT Equipment FROM EquipmentList WHERE TeamID =" + ID + " ORDER BY " + Name + " ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbEqList.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbEqList.Items.Add(ro[Name].ToString());
            }
        }
        void showParts(int ID)
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentConnListToPart AS Econ INNER JOIN EquipmentPart AS Epart ON Econ.PartID" +
                "=  Epart.ID WHERE Econ.ListID = " + ID + " ORDER BY Epart.PartName", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbEqPart.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbEqPart.Items.Add(ro["PartName"].ToString());
            }
        }
        void showPoints(int ID)
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentConnPartToPoint AS Econ INNER JOIN EquipmentPoint AS Epoint ON Econ.PointID" +
                " = Epoint.ID WHERE Econ.PartID = " + ID + " ORDER BY Epoint.Name", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbEqPoint.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbEqPoint.Items.Add(ro["Name"].ToString());
            }
        }
        void showSensors()
        {
            adpt = new SqlDataAdapter("SELECT * FROM EquipmentSensor ORDER BY Name ASC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbSensor.Items.Clear();
            foreach (DataRow ro in tb.Rows)
            {
                lbSensor.Items.Add(ro["Name"].ToString());
            }
        }
        void showCreated(string Employee)
        {
            adpt = new SqlDataAdapter("SELECT TOP (10) * FROM RegistredProblems WHERE  Creator = '" + Employee +
                "' AND StatusBar = 'Не принято в работу' ORDER BY RegDate DESC", conn);
            tb = new DataTable();
            adpt.Fill(tb);
            lbCreated.Items.Clear();
            int i=0;
            string item;
            foreach (DataRow ro in tb.Rows)
            {
                i++;
                item = i.ToString() + ". " + ro["Descript"].ToString(); 
                lbCreated.Items.Add(item);
            }
        }

        private void lbEqPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEqPoint.SelectedItem.ToString() == "інше" || lbEqPoint.SelectedItem.ToString() == "Інше")
            {
                lbSensor.Visible = false;
                lSensor.Visible = false;
            }
            else
            {
                lbSensor.Visible = true;
                lSensor.Visible = true;
                showSensors();
            }
            
        }

        private void lbPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbEqTeam.Visible = true;
            lTeam.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            //Environment.Exit(0);
            string message = "Закрыть без регистрации проблемы?";
            string title = "Exit Now";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.ToString() == "")
            {
                MessageBox.Show("Опишите проблему");
                return;
            }
            if (lbPlans.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете Номер плана");
                return;
            }
            if (lbDept.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете Отдел");
                return;
            }
            if (lbEmployee.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете Сотрудника");
                return;
            }
            if (lbEqPoint.Visible == true && lbEqPoint.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете подкатегорию проблемы");
                return;
            }
            if (lbEqList.SelectedItems.Count < 1 || lbEqPart.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете Оборудование");
                return;
            }
            if (lbSensor.Visible == true && lbSensor.SelectedItems.Count < 1)
            {
                MessageBox.Show("Выберете Датчик");
                return;
            }
            string message = "Зарегистрировать проблему?";
            string title = "Register Now";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection cn = new SqlConnection(@"Data Source=GOLD-PEN\SQLEXPRESSMES;Initial Catalog = MES_Project; Integrated Security = True"))
                {
                    try
                    {
                        string category3 = "";
                        string sensor = "";
                        if (lbEqPoint.Visible == true)
                        {
                            category3 = (lbEqPart.SelectedItem.ToString() == "інше") ? "" : lbEqPoint.SelectedItem.ToString();
                        }
                        if (lbSensor.Visible == true)
                        {
                            sensor = (lbEqPoint.SelectedItem.ToString() == "Інше") ? "" : lbSensor.SelectedItem.ToString();
                        }
                        cn.Open();
                        string strSQL = "INSERT INTO [RegistredProblems] VALUES (" +
                            Convert.ToInt32(lbPlans.SelectedItem.ToString()) + ", '" +
                            datepicker.Value.ToString("yyyy-MM-d HH:mm:ss") + "', '" +
                            lbDept.SelectedItem.ToString() + "', '" +
                            lbEmployee.SelectedItem.ToString() + "', '" +
                            lbEqList.SelectedItem.ToString() + "', '" +
                            txtDescription.Text + "', '" +
                            "Не принято в работу', " +
                            "getdate(), '', '', '', '', '', '', '" +
                            lbEqPart.SelectedItem.ToString() + "', '" +
                            category3 + "', '" +
                            sensor + "')";
                        SqlCommand cmd = new SqlCommand(strSQL, cn);
                        if (cmd.ExecuteNonQuery() == 1)
                            MessageBox.Show("Проблема успешно добавлена");
                        cn.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        void RegNewProblem()
        {
            System.Data.SqlClient.SqlConnection sqlConnection =
            new System.Data.SqlClient.SqlConnection(@"Data Source = GOLD - PEN\SQLEXPRESSMES; Initial Catalog = MES_Project; Integrated Security = True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT Region (RegionID, RegionDescription) VALUES (5, 'NorthWestern')";
            cmd.Connection = sqlConnection;

            try
            {
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Cant Execute");
            }

        }

        private void lbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            lCreated.Visible = true;
            lbCreated.Visible = true;
            lbEqTeam.Visible = true;
            lTeam.Visible = true;
            showCreated(lbEmployee.SelectedItem.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
