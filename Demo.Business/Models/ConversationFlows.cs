namespace Demo.Business.Models
{
    public class ConversationFlows
    {
        public MainMenu MainMenu { get; set; } = new MainMenu();
        public AppointmentBooking AppointmentBooking { get; set; } = new AppointmentBooking();
        public ViewAppointments ViewAppointments { get; set; } = new ViewAppointments();
        public CancelAppointment CancelAppointment { get; set; } = new CancelAppointment();
    }
}