using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ThemeStyle = Product_Manage_Tool_WF.IO.ThemeStyle;

namespace Product_Manage_Tool_WF.Forms
{
    public partial class FrmMain : Form
    {
        //
        //Declare private variables
        //
        private Button CurrentButton;
        private static Form ActivatingForm;
        private Random random;
        private static int tempThemeColorIndex;
        //
        //==========================================================================================================================
        //
        //METHODS
        //
        //--select theme
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeStyle.ColorList.Length);
            while (tempThemeColorIndex == index)
            {
                index = random.Next(ThemeStyle.ColorList.Length);
            }
            tempThemeColorIndex = index;
            string color = ThemeStyle.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        //---set theme for active buttons
        private void ActivateButton(object btnSender)
        {
            if (CurrentButton != (Button)btnSender)
            {
                //Set style for the other menu buttons
                DeactivateAllMenuButton();

                //Set style for pressed button
                Color color = SelectThemeColor();
                CurrentButton = (Button)btnSender;
                CurrentButton.BackColor = color;
                CurrentButton.ForeColor = Color.White;
                CurrentButton.Font = ThemeStyle.ACTIVE_BTN_FONT_STYLE;

                //Set style for Title panel
                lblTitle.Text = CurrentButton.Text.TrimStart(' ');
                pnlTitle.BackColor = color;
            }

        }
        //---set theme for inactive buttons
        private void DeactivateAllMenuButton()
        {
            foreach (Control PreviousCtr in pnlMenu.Controls)
            {
                if (PreviousCtr.GetType() == typeof(Button))
                {
                    Button PreviousBtn = (Button)PreviousCtr;
                    PreviousBtn.BackColor = ThemeStyle.INACTIVE_BTN_BACK_GROUND_COLOR;
                    PreviousBtn.ForeColor = ThemeStyle.INACTIVE_BTN_FORE_COLOR;
                    PreviousBtn.Font = ThemeStyle.INACTIVE_BTN_FONT_STYLE;
                }
            }

        }
        //---method for opening form & setting it into panel
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActivatingForm != null)
            {
                ActivatingForm.Hide();
            }
            ActivateButton(btnSender);

            ActivatingForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        public FrmMain()
        {
            InitializeComponent();

            //initialize random (prevent null error)
            random = new Random();

            //initialize controls
            OpenChildForm(new Child_Forms.FrmAddProduct(), (object)btnProductManagement);
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.FrmAddProduct(), sender);
        }

        private void btnTypeManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.FrmAddProductType(), sender);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Child_Forms.FrmSearch(), sender);
        }
    }
}
