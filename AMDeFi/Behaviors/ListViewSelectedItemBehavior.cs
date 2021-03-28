using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AMDeFi.Behaviors
{
    /// <summary>
    /// List view selected item behavior.
    /// Ref - https://github.com/davidbritch/xamarin-forms/blob/master/ItemSelectedBehavior/ItemSelectedBehavior/Behaviors/ListViewSelectedItemBehavior.cs
    /// </summary>
    public class ListViewSelectedItemBehavior : Behavior<ListView>
    {
        #region Bindable Properties
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(ListViewSelectedItemBehavior), null);
        public static readonly BindableProperty InputConverterProperty = BindableProperty.Create("Converter", typeof(IValueConverter), typeof(ListViewSelectedItemBehavior), null);
        #endregion

        #region Public Properties
        /// <summary>
        /// Get or set selected item commamnd
        /// </summary>
        /// <value>The command.</value>
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        /// <summary>
        /// Get or set Ivalueconverter param
        /// </summary>
        /// <value>The converter.</value>
        public IValueConverter Converter
        {
            get { return (IValueConverter)GetValue(InputConverterProperty); }
            set { SetValue(InputConverterProperty, value); }
        }

        /// <summary>
        /// Instance of listivew
        /// </summary>
        /// <value>The associated object.</value>
        public ListView AssociatedObject { get; private set; }
        #endregion

        #region Override Methods
        /// <summary>
        /// Attaching behavior to UI
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject = bindable;
            bindable.BindingContextChanged += OnBindingContextChanged;
            bindable.ItemSelected += OnListViewItemSelected;
        }
        /// <summary>
        /// Detaching behavior from the UI control
        /// </summary>
        /// <param name="bindable">Bindable.</param>
        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.BindingContextChanged -= OnBindingContextChanged;
            bindable.ItemSelected -= OnListViewItemSelected;
            AssociatedObject = null;
        }
        /// <summary>
        /// Overriding binding context default values
        /// </summary>
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Listview binding context changed
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void OnBindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }
        /// <summary>
        /// Listview item selected event
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (Command == null || e.SelectedItem == null)
            {
                return;
            }

            object parameter = Converter.Convert(e, typeof(object), null, null);
            if (Command.CanExecute(parameter))
            {
                Command.Execute(parameter);
            }
        }
        #endregion
    }
}

