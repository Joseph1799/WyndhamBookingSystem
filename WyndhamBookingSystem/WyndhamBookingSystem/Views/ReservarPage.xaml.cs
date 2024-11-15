namespace WyndhamBookingSystem.Views
{
    public partial class ReservarPage : ContentPage
    {
        public ReservarPage()
        {
            InitializeComponent();

            // Optionally set the minimum date for the check-in date
            startDatePicker.MinimumDate = DateTime.Today;
            endDatePicker.MinimumDate = DateTime.Today.AddDays(1);
        }

        // Handle DateSelected event for the Start Date (Check-in)
        private void OnStartDateSelected(object sender, DateChangedEventArgs e)
        {
            // Prevent the start date from being later than the end date
            if (e.NewDate > endDatePicker.Date)
            {
                // If the new start date is later than the end date, reset the end date
                endDatePicker.Date = e.NewDate;
            }

            // Ensure that the check-in date is not the same as the check-out date
            if (e.NewDate == endDatePicker.Date)
            {
                // Optionally, adjust the end date to a day after the start date
                endDatePicker.Date = e.NewDate.AddDays(1);
            }
        }

        // Handle DateSelected event for the End Date (Check-out)
        private void OnEndDateSelected(object sender, DateChangedEventArgs e)
        {
            // Prevent the end date from being earlier than the start date
            if (e.NewDate < startDatePicker.Date)
            {
                // If the new end date is earlier than the start date, reset the start date
                startDatePicker.Date = e.NewDate;
            }

            // Ensure that the check-out date is not the same as the check-in date
            if (e.NewDate == startDatePicker.Date)
            {
                // Optionally, adjust the start date to a day before the end date
                startDatePicker.Date = e.NewDate.AddDays(-1);
            }
        }
    }
}