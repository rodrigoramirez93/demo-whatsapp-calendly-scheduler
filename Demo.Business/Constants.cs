namespace Demo.Business
{
    public enum MessageType
    {
        Error,
        Welcome,
        Menu,
        Confirmation,
        Button,
        InputRequest,
        Selection,
        Instruction,
        FinalConfirmation,
        FormattedInfo,
        ListHeader,
        EmptyState,
        CancellationConfirmation
    }

    public enum HandlerCategory
    {
        Welcome,
        Menu,
        Provider,
        Timeslots,
        User,
        ErrorHandler
    }

    public enum DecisionPointType
    {
        ProviderSelection,
        ServiceSelection,
        WeekSelection,
        DaySelection,
        TimeSelection,
        UserInfoInput
    }

    public enum ConditionalMessageCondition
    {
        NoAppointments,
        HasAppointments
    }
}
