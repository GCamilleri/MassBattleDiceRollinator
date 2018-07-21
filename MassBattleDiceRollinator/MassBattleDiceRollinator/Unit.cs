using System.ComponentModel;

namespace MassBattleDiceRollinator
{
	public abstract class Unit : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private bool _Enabled;
		private string _Name;

		public Unit(string name)
		{
			Name = name;
		}

		public bool Enabled
		{
			get { return _Enabled; }
			set
			{
				_Enabled = value;
				OnPropertyChanged(nameof(Enabled));
			}
		}

		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
				OnPropertyChanged(nameof(Name));
			}
		}

		protected void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
