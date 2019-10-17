using System;
using System.Drawing;
using System.Windows.Forms;

// Eine eigne Form-Klasse anlegen mit Vererbung
class CForm : Form
{
    public CForm()
    {
        this.Text = "Windows-Forms";
        this.BackColor = Color.Blue;
    }
}
public class Program
{
    public static void Main()
    {
        CForm zweiteForm = new CForm();
        Application.Run(zweiteForm);
    }
}