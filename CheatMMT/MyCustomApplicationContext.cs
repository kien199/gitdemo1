using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatMMT
{
	public class MyCustomApplicationContext : ApplicationContext
	{
		private NotifyIcon trayIcon;
		private Form1 frm = new Form1();

		public MyCustomApplicationContext()
		{
			// Initialize Tray Icon
			trayIcon = new NotifyIcon()
			{
				Icon = Properties.Resources.AppIcon,
				ContextMenu = new ContextMenu(new MenuItem[] {
				new MenuItem("Exit", Exit)
			}),
				Visible = true
			};

			this.MainForm = frm;
			trayIcon.Click += (o, e) => { MainForm.Show(); };
		}

		void Exit(object sender, EventArgs e)
		{
			// Hide tray icon, otherwise it will remain shown until user mouses over it
			trayIcon.Visible = false;
			//MainForm.Close();
			Application.Exit();
		}
	}
}
