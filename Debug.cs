using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ServiceProcess;
using System.Security.Principal;

namespace Debuger
{
		
	public static class AntiDebuggerModule
	{



		public static string[] titles = {

				"ILSpy",
				"x32dbg",
				"sharpod",
				"x64dbg",
				"x32_dbg",
				"x64_dbg",
				"strongod",
				"PhantOm",
				"titanHide",
				"scyllaHide",
				"ilspy",
				"graywolf",
				"simpleassemblyexplorer",
				"MegaDumper",
				"megadumper",
				"X64NetDumper",
				"x64netdumper",
				"process hacker 2",
				"ollydbg",
				"x32dbg",
				"x64dbg",
				"ida -",
				"charles",
				"dnspy",
				"httpanalyzer",
				"httpdebug",
				"fiddler",
				"wireshark",
				"proxifier",
				"mitmproxy",
				"process hacker",
				"process monitor",
				"process hacker 2",
				"system explorer",
				"systemexplorer",
				"systemexplorerservice",
				"WPE PRO",
				"ghidra",
				"x32dbg",
				"x64dbg",
				"ollydbg",
				"ida -",
				"charles",
				"dnspy",
				"Th3ken",
				"VEWEWQ"
				"httpanalyzer",
				"httpdebug",
				"http debugger",
				"fiddler",
				"wireshark",
				"dbx",
				"mdbg",
				"gdb",
				"windbg",
				"dbgclr",
				"kdb",
				"kgdb",
				"mdb"
				};
			
			
			public static void Start() {
				sbx = 2;
				ThreadPool.QueueUserWorkItem(runner);
			}
			
			public static void Stop() {
				sbx = 1;
			}
			public static void Crash() {
				StreamReader sr = new StreamReader("dotNETJSONParser.dll"); // to crash the program by reading a non existent file. So an inexperienced reverser will be confused.
				string dmp = sr.ReadLine();
				sr.Close();
				int dbnum = 1;
				dbnum--;
				int dbgnum = 1/dbnum; // Division by zero (crash) just in case he puts a file with the specified name.
				Environment.FailFast("Please use a 32 bit debugger."); // another fake crash message.
				
			}
			public static int sbx = 1;
			public static void runner(object state) {
				
				while(sbx == 2) {
				Process[] prs = Process.GetProcesses();
				foreach (Process prcs in prs) {
					for (int i = 0; i < titles.Length; i++) {
						if (prcs.MainWindowTitle.ToLower().Replace("ı","i").Contains(titles[i]) || prcs.ProcessName.ToLower().Replace(".exe","") == "charles") {							
							
							Crash();
					
					}
					}
					
				}
				Thread.Sleep(1000);
				}
			}
			
			
					
	}
}
