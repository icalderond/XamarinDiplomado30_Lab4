using System;
namespace PCLProject
{
	public class AppValidator
	{
		IDialog Dialog;
		public AppValidator(IDialog platformDialog)
		{
			Dialog = platformDialog;
		}
		public string EMail { get; set; }
		public string Password { get; set; }
		public string Device { get; set; }
		public void Validate()
		{
			string Result;
			/* Aquí se puede implementar la funcionalidad
			 principal de la clase. Por el momento solo devuelve
			 una cadena fija. */
			Result = "¡Aplicación validada!";
			/* Invocar el código específico de la plataforma */
			Dialog.Show(Result);
		}
	}
}
