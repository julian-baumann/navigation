using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using System.Web;

namespace Navigation
{
	/// <summary>
	/// Configures state information contained in the Navigation/StateInfo section. A child
	/// of a <see cref="Navigation.Dialog"/> element it represents a <see cref="System.Web.UI.Page"/>
	/// that can be visisted
	/// </summary>
	[Serializable]
	public partial class State
	{
		private StateInfoCollection<Transition> _Transitions = new StateInfoCollection<Transition>();
		private Dialog _Parent;
		private int _Index;
		private string _Key;
		private StateInfoCollection<Type> _DefaultTypes;
		private StateInfoCollection<object> _Defaults;
		private StateInfoCollection<string> _FormattedDefaults;
		private ReadOnlyCollection<string> _Derived;
		private Dictionary<string, string> _DerivedInternal;
		private string _Title;
#if NET40Plus
		private string _Route;
#endif
		private bool _TrackCrumbTrail;
		private string _ResourceType;
		private string _ResourceKey;
		private StateInfoCollection<string> _Attributes;
		[NonSerialized]
		private IStateHandler _StateHandler;

		/// <summary>
		/// Initializes a new instance of the <see cref="Navigation.State"/> class and sets the default
		/// <see cref="IStateHandler"/>
		/// </summary>
		public State()
		{
			SetStateHandler();
		}

		/// <summary>
		/// Gets the <see cref="Navigation.Transition"/> children
		/// </summary>
		public StateInfoCollection<Transition> Transitions
		{
			get
			{
				return _Transitions;
			}
		}

		/// <summary>
		/// Gets the parent <see cref="Navigation.Dialog"/> configuration item
		/// </summary>
		public Dialog Parent
		{
			get
			{
				return _Parent;
			}
			internal set
			{
				_Parent = value;
			}
		}

		/// <summary>
		/// Gets the number of the state within its <see cref="Parent"/> as read
		/// sequentially from the configuration section
		/// </summary>
		public int Index
		{
			get
			{
				return _Index;
			}
			internal set
			{
				_Index = value;
			}
		}

		/// <summary>
		/// Gets the key, unique within a <see cref="Parent"/>, used by <see cref="Navigation.Dialog"/>
		/// and <see cref="Navigation.Transition"/> elements to specify navigation configuration
		/// </summary>
		public string Key
		{
			get
			{
				return _Key;
			}
			internal set
			{
				_Key = value;
			}
		}

		/// <summary>
		/// Gets the default <see cref="Navigation.NavigationData"/> <see cref="System.Type"/>'s for 
		/// this <see cref="Navigation.State"/>
		/// </summary>
		public StateInfoCollection<Type> DefaultTypes
		{
			get
			{
				return _DefaultTypes;
			}
			internal set
			{
				_DefaultTypes = value;
			}
		}

		/// <summary>
		/// Gets the default <see cref="Navigation.NavigationData"/> for this <see cref="Navigation.State"/>
		/// </summary>
		public StateInfoCollection<object> Defaults
		{
			get
			{
				return _Defaults;
			}
			internal set
			{
				_Defaults = value;
			}
		}

		internal StateInfoCollection<string> FormattedDefaults
		{
			get
			{
				return _FormattedDefaults;
			}
			set
			{
				_FormattedDefaults = value;
			}
		}

		/// <summary>
		/// Gets the derived <see cref="Navigation.NavigationData"/> for this <see cref="Navigation.State"/>
		/// </summary>
		public ReadOnlyCollection<string> Derived
		{
			get
			{
				return _Derived;
			}
			internal set
			{
				_Derived = value;
			}
		}

		internal Dictionary<string, string> DerivedInternal
		{
			get
			{
				return _DerivedInternal;
			}
			set
			{
				_DerivedInternal = value;
			}
		}

		/// <summary>
		/// Gets the textual description of the state. The resourceType and resourceKey attributes can be 
		/// used for localization
		/// </summary>
		public string Title
		{
			get
			{
				if (ResourceKey.Length != 0)
				{
					return (string)HttpContext.GetGlobalResourceObject(ResourceType, ResourceKey, Thread.CurrentThread.CurrentUICulture);
				}
				return _Title;
			}
			internal set
			{
				_Title = value;
			}
		}

#if NET40Plus
		/// <summary>
		/// Gets the route Url pattern
		/// </summary>
		public string Route
		{
			get
			{
				return _Route;
			}
			internal set
			{
				_Route = value;
			}
		}
#endif

#if NET40Plus
		/// <summary>
		/// Gets a value that indicates whether to maintain crumb trail information 
		/// e.g <see cref="Navigation.StateContext.PreviousState"/>. This can be used together 
		/// with <see cref="Route"/> to produce user friendly Urls
		/// </summary>
#else
		/// <summary>
		/// Gets a value that indicates whether to maintain crumb trail information 
		/// e.g <see cref="Navigation.StateContext.PreviousState"/>
		/// </summary>
#endif
		public bool TrackCrumbTrail
		{
			get
			{
				return _TrackCrumbTrail;
			}
			internal set
			{
				_TrackCrumbTrail = value;
			}
		}

		internal string ResourceType
		{
			get
			{
				return _ResourceType;
			}
			set
			{
				_ResourceType = value;
			}
		}

		internal string ResourceKey
		{
			get
			{
				return _ResourceKey;
			}
			set
			{
				_ResourceKey = value;
			}
		}

		/// <summary>
		/// Gets the list of attributes as read from the configuration section
		/// </summary>
		public StateInfoCollection<string> Attributes
		{
			get
			{
				return _Attributes;
			}
			internal set
			{
				_Attributes = value;
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="Navigation.IStateHandler"/> responsible for building and parsing
		/// navigation links to this <see cref="Navigation.State"/>
		/// </summary>
		public IStateHandler StateHandler
		{
			get
			{
				return _StateHandler;
			}
			set
			{
				_StateHandler = value;
			}
		}

		internal string StateKey
		{
			get
			{
				return Index.ToString(NumberFormatInfo.InvariantInfo);
			}
		}

		/// <summary>
		/// Gets the unique identifier for this <see cref="Navigation.State"/>
		/// </summary>
		public string Id
		{
			get
			{
				return Parent.Index.ToString(NumberFormatInfo.InvariantInfo) + "-" + Index.ToString(NumberFormatInfo.InvariantInfo);
			}
		}

		internal bool DefaultOrDerived(string key, object value)
		{
			return value.Equals(Defaults[key]) || DerivedInternal.ContainsKey(key);
		}

		partial void SetStateHandler();
	}
}
