﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceWebbshop
{
	public partial class Service1 : ServiceBase
	{

		webshopdbEntities db = new webshopdbEntities();

		Timer timer = new Timer(); // name space(using System.Timers;)  
	
		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			WriteToFile("Service is started at " + DateTime.Now);
			timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
			timer.Interval = 5000; //number in milisecinds  
			timer.Enabled = true;
		}

		protected override void OnStop()
		{
			WriteToFile("Service is stopped at " + DateTime.Now);
		}
		private void OnElapsedTime(object source, ElapsedEventArgs e)
		{
			StreamReader stremr = new StreamReader("C:/Users/patri/Source/Repos/WindowsServiceWebbshop/WindowsServiceWebbshop/TextFile1.txt");
			using (stremr)
			{
				while (true)
				{
					string input = stremr.ReadLine();
					if (input == null)
					{
						break;
					}
					else
					{
						Category cate = db.Category.FirstOrDefault(x => x.categoryname == input);
						if (cate == null)
						{
							Category newcate = new Category();
							newcate.categoryname = input;
							db.Category.Add(newcate);
							WriteToFile("Service added new category " + DateTime.Now);
						}
					}

			}
				db.SaveChanges();
			}

				WriteToFile("Service is recall at " + DateTime.Now);
		}
		public void WriteToFile(string Message)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
			if (!File.Exists(filepath))
			{
				// Create a file to write to.   
				using (StreamWriter sw = File.CreateText(filepath))
				{
					sw.WriteLine(Message);
				}
			}
			else
			{
				using (StreamWriter sw = File.AppendText(filepath))
				{
					sw.WriteLine(Message);
				}
			}
		}
	}
}