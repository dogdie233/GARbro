using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

using GameRes.Formats.NekoNyan;

namespace GameRes.Formats.GUI
{
    /// <summary>
    /// Interaction logic for WidgetXP3.xaml
    /// </summary>
    public partial class WidgetSpriteGameChoice : StackPanel
    {
        public WidgetSpriteGameChoice()
        {
            InitializeComponent();
            var keys = new[] { new KeyValuePair<string, SpriteGameDatabase.Item> ("Not nekonyan/sprite game", null) };
            this.DataContext = keys.Concat (SpriteGameDatabase.Games.Select(item => new KeyValuePair<string, SpriteGameDatabase.Item>(item.Name, item)));
            this.Loaded += (s, e) => {
                this.Scheme.SelectedIndex = 0;
            };
        }
    }
}
