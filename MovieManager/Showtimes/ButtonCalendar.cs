using MovieManager_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MovieManager.Showtimes
{
    public class ButtonCalendar : RadioButton
    {
        public static readonly DependencyProperty MonthProperty = DependencyProperty.Register("Month", typeof(string), typeof(ButtonCalendar), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty WeekdayProperty = DependencyProperty.Register("Weekday", typeof(string), typeof(ButtonCalendar), new FrameworkPropertyMetadata(string.Empty));
        public static readonly DependencyProperty DayProperty = DependencyProperty.Register("Day", typeof(string), typeof(ButtonCalendar), new FrameworkPropertyMetadata(string.Empty));

       
        public string Month
        {
            get { return (string)GetValue(MonthProperty); }

            set { SetValue(MonthProperty, value); }
        }
        public string Weekday
        {
            get { return (string)GetValue(WeekdayProperty); }
            set { SetValue(WeekdayProperty, value); }
        }
        public string Day
        {
            get { return (string)GetValue(DayProperty); }
            set { SetValue(DayProperty, value); }
        }

        public void SetDate(DateTime date, RapChieuPhimDTO rapDTO)
        {
            Month = date.Month.ToString();
            Day = date.Day.ToString();
            Weekday = date.DayOfWeek.ToString().Substring(0, 3);
            this.Tag = rapDTO.ID.ToString() + '|' + date.ToString();
        }

        public ButtonCalendar()
        {
            ResourceDictionary dictionary = new ResourceDictionary();
            dictionary.Source = new Uri("/MovieManager;component/Resources/Styles/ButtonCalendar.xaml", UriKind.Relative);
            this.Style = (Style)dictionary["ButtonCalendarStyle"];
            
        }
    }
}
