using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationDB
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

             private void mainForm_Load(object sender, EventArgs e)
        {
            RefreshGrid("Sizes");
            mainForm.ActiveForm.Width = 622;
            mainForm.ActiveForm.Height = 305;
            btnClosePosition(232, 235);
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UnitofWork uow = new UnitofWork();
            Size size = new Size();
            size.Name = txtName.Text;
            size.Diameter = Int16.Parse(txtDiameter.Text);
            size.Coefficient = Double.Parse(txtCoefficient.Text);
            uow.Sizes.Create(size);
            uow.Save();
            RefreshGrid("Sizes");        


        }

        public void RefreshGrid(string gridName)
        {
            UnitofWork unit = new UnitofWork();
          //  var list = new UnitofWork();
            switch (gridName)
            {
                case "Sizes":
                    {
                        dataGridSizes.Rows.Clear();
                        dataGridSizes.Refresh();

                        var list = unit.Sizes.GetList();

                        foreach (var item in list)
                        {
                            dataGridSizes.Rows.Add(item.Id, item.Name, item.Diameter, item.Coefficient);
                        }
                        break;
                    }          
                case "Users":
                    {
                        dataGridUsers.Rows.Clear();
                        dataGridUsers.Refresh();
                        var list = unit.Users.GetList();
                        foreach (var item in list)
                        {
                            dataGridUsers.Rows.Add(item.Id, item.Login, item.Password,item.Name,item.Surname,item.Number,item.Email,item.Address,item.Role);
                        }
                        break;
                    }
                case "Roles":
                    {
                        dataGridRoles.Rows.Clear();
                        dataGridRoles.Refresh();
                        var list = unit.Roles.GetList();
                        foreach (var item in list)
                        {
                            dataGridRoles.Rows.Add(item.Id, item.Name);
                        }
                        break;
                    }

            }
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UnitofWork unit = new UnitofWork();
            unit.Sizes.Delete(Int32.Parse(txtDeleteId.Text));
            unit.Save();
            RefreshGrid("Sizes");
        }

        private void tap1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabUsers_Enter(object sender, EventArgs e)
        {
            RefreshGrid("Users");
            mainForm.ActiveForm.Width = 763;
            mainForm.ActiveForm.Height = 375;
            tab.Width =723;
            tab.Height = 289;
            btnClosePosition(323, 305);
            
           }

        
        public void btnClosePosition(int left,int top)
        {
            btnClose.Left = left;
            btnClose.Top = top;
        }
        private void tapSizes_Enter(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Width = 622;
            mainForm.ActiveForm.Height = 305;
            tab.Width = 581;
            tab.Height = 213;
            tapSizes.Width = 573;
            tapSizes.Height = 193;
            //   btnClose.Location(232, 235);
            //   btnClose.Location.X=232;
            btnClosePosition(232, 235);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UnitofWork uow = new UnitofWork();
            User user = new User();
            user.Login = txtL.Text;
            user.Password = txtP.Text;
            user.Name = txtN.Text;
            user.Surname = txtS.Text;
            user.Number = txtNum.Text;
            user.Email = txtE.Text;
            user.Address = txtA.Text;
            user.Role = Int16.Parse(txtR.Text);
            uow.Users.Create(user);
            uow.Save();
            RefreshGrid("Users");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabRole_Enter(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Width = 371;
            mainForm.ActiveForm.Height = 303;
            tab.Width = 330;
            tab.Height = 207;       
            btnClosePosition(125, 230);
            RefreshGrid("Roles");
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            UnitofWork uow = new UnitofWork();
            Role role = new Role();
            role.Name = txtRoleName.Text;
            uow.Roles.Create(role);
            uow.Save();
            RefreshGrid("Roles");

        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            UnitofWork unit = new UnitofWork();
            unit.Roles.Delete(Int32.Parse(txtDeleteIdRole.Text));
            unit.Save();
            txtDeleteIdRole.Clear();
            RefreshGrid("Roles");
        }

        private void dataGridRoles_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelU_Click(object sender, EventArgs e)
        {
            UnitofWork unit = new UnitofWork();
            unit.Users.Delete(Int32.Parse(txtDelU.Text));
            unit.Save();
            txtDelU.Clear();
            RefreshGrid("Users");
        }

       

        private void mainForm_Activated(object sender, EventArgs e)
        {
            mainForm.ActiveForm.Width = 622;
            mainForm.ActiveForm.Height = 305;
            tab.Width = 581;
            tab.Height = 213;
            tapSizes.Width = 573;
            tapSizes.Height = 193;
          
        }

        private void mainForm_Load_1(object sender, EventArgs e)
        {
            RefreshGrid("Sizes");
        }
    }
}
