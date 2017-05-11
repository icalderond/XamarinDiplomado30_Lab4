using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
	[Activity(Label = "AndroidApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			/* Creamos la instancia del código compartido
			 y le inyectamos la dependencia. */
			var Validator =
				new PCLProject.AppValidator(new AndroidDialog(this));
			/* Aquí podríamos establecer los valores de las propiedades
			 * EMail, Password y Device*/
			// Realizamos la validación

			Validator.EMail = "TuCorreoElectrónico";
			Validator.Password = "TuContraseña";
			Validator.Device =
				Android.Provider.Settings.Secure.GetString(
					ContentResolver,
					Android.Provider.Settings.Secure.AndroidId);

			Validator.Validate();
			// Set our view from the "main" layout resource
			// SetContentView (Resource.Layout.Main);
		}
	}
}

