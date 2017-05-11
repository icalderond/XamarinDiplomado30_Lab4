using System;
using Android.App;
using Android.Content;

namespace AndroidApp
{
	public class AndroidDialog : PCLProject.IDialog
	{
		Context AppContext;
		public AndroidDialog(Context context)
		{
			AppContext = context;
		}
		public void Show(string message)
		{
			Android.App.AlertDialog.Builder Builder =
					new AlertDialog.Builder(AppContext);
			AlertDialog Alert = Builder.Create();
			Alert.SetTitle("Resultado de la verificación");
			Alert.SetIcon(Resource.Mipmap.Icon);
			Alert.SetMessage(message);
			Alert.SetButton("Ok", (s, ev) => { });
			Alert.Show();
		}
	}
}
