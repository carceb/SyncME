namespace DM.Enums
{
    public enum SourceEvent
    {
        Unknown = 0,
        Created = 1,
        Changed = 2,
        Renamed = 3,
        Deleted = 4,
        Error = 5
    }

    public enum MirrorAction
    {
        Unknown = 0,
        CreateDirectory = 1,
        Copy = 2,
        CopyRecursively = 3,
        Delete = 4,
        Error = 5,
        TimerElapsed = 6,
        BeginUpdate = 7,
        EndUpdate = 8
    }

    public enum DisplayEventOption
    {
        Unknown = 0,
        SourceEvent = 1,
        SourceError = 2,
        MirrorAction = 3,
        MirrorError = 4
    }
}
