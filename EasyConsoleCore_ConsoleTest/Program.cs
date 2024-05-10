using Demo.Pages;

using IVolt.Applications.EasyConsole;
using IVolt.Applications.EasyConsole.Testing;

namespace IVolt.Applications.EasyConsole.Testing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			new DemoProgram().Run();
		}
	}

	public class DemoProgram : EasyConsole_Program
	{
		public DemoProgram()
			 : base("EasyConsole Demo", breadcrumbHeader: true)
		{
			AddPage(new MainPage(this));
			AddPage(new Page1(this));
			AddPage(new Page1A(this));
			AddPage(new Page1Ai(this));
			AddPage(new Page1B(this));
			AddPage(new Page2(this));
			AddPage(new InputPage(this));

			SetPage<MainPage>();
		}
	}
}
