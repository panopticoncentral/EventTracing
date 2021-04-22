using System;

#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1720 // Identifier contains type name

namespace EtwTools
{
    /// <summary>
    /// Provider for Microsoft-VisualStudio-Threading ({589491ba-4f15-53fe-c376-db7f020f5204})
    /// </summary>
    public sealed class MicrosoftVisualStudioThreadingProvider
    {
        /// <summary>
        /// Provider ID.
        /// </summary>
        public static readonly Guid Id = new("{589491ba-4f15-53fe-c376-db7f020f5204}");

        /// <summary>
        /// Provider name.
        /// </summary>
        public const string Name = "Microsoft-VisualStudio-Threading";

        /// <summary>
        /// An event wrapper for a EventSourceMessage event.
        /// </summary>
        public readonly ref struct EventSourceMessageEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "EventSourceMessage";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 0,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.None,
                Opcode = EtwEventType.Info,
                Task = (ushort)Tasks.EventSourceMessage,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public EventSourceMessageData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new EventSourceMessageEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public EventSourceMessageEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a EventSourceMessage event.
            /// </summary>
            public readonly ref struct EventSourceMessageData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_Message = 0;

                /// <summary>
                /// Retrieves the Message field.
                /// </summary>
                public string Message => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_Message..]);

                /// <summary>
                /// Creates a new EventSourceMessageData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public EventSourceMessageData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a CompleteOnCurrentThreadStop event.
        /// </summary>
        public readonly ref struct CompleteOnCurrentThreadStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "CompleteOnCurrentThreadStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 12,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventType.Stop,
                Task = (ushort)Tasks.CompleteOnCurrentThreadStop,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public CompleteOnCurrentThreadStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new CompleteOnCurrentThreadStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public CompleteOnCurrentThreadStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a CompleteOnCurrentThreadStop event.
            /// </summary>
            public readonly ref struct CompleteOnCurrentThreadStopData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_TaskId = 0;

                /// <summary>
                /// Retrieves the TaskId field.
                /// </summary>
                public int TaskId => BitConverter.ToInt32(_etwEvent.Data[Offset_TaskId..]);

                /// <summary>
                /// Creates a new CompleteOnCurrentThreadStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public CompleteOnCurrentThreadStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WaitSynchronouslyStart event.
        /// </summary>
        public readonly ref struct WaitSynchronouslyStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WaitSynchronouslyStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 13,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventType.Start,
                Task = (ushort)Tasks.WaitSynchronously,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Creates a new WaitSynchronouslyStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WaitSynchronouslyStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a WaitSynchronouslyStop event.
        /// </summary>
        public readonly ref struct WaitSynchronouslyStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WaitSynchronouslyStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 14,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventType.Stop,
                Task = (ushort)Tasks.WaitSynchronously,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Creates a new WaitSynchronouslyStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WaitSynchronouslyStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a PostExecutionStop event.
        /// </summary>
        public readonly ref struct PostExecutionStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "PostExecutionStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 16,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventType.Stop,
                Task = (ushort)Tasks.PostExecutionStop,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public PostExecutionStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new PostExecutionStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public PostExecutionStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a PostExecutionStop event.
            /// </summary>
            public readonly ref struct PostExecutionStopData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_RequestId = 0;

                /// <summary>
                /// Retrieves the RequestId field.
                /// </summary>
                public int RequestId => BitConverter.ToInt32(_etwEvent.Data[Offset_RequestId..]);

                /// <summary>
                /// Creates a new PostExecutionStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public PostExecutionStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a CircularJoinableTaskDependencyDetected event.
        /// </summary>
        public readonly ref struct CircularJoinableTaskDependencyDetectedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "CircularJoinableTaskDependencyDetected";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 17,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventType.Info,
                Task = (ushort)Tasks.CircularJoinableTaskDependencyDetected,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public CircularJoinableTaskDependencyDetectedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new CircularJoinableTaskDependencyDetectedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public CircularJoinableTaskDependencyDetectedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a CircularJoinableTaskDependencyDetected event.
            /// </summary>
            public readonly ref struct CircularJoinableTaskDependencyDetectedData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_InitUnreachableCount = 0;
                private const int Offset_ReachableCount = 4;

                /// <summary>
                /// Retrieves the InitUnreachableCount field.
                /// </summary>
                public int InitUnreachableCount => BitConverter.ToInt32(_etwEvent.Data[Offset_InitUnreachableCount..Offset_ReachableCount]);

                /// <summary>
                /// Retrieves the ReachableCount field.
                /// </summary>
                public int ReachableCount => BitConverter.ToInt32(_etwEvent.Data[Offset_ReachableCount..]);

                /// <summary>
                /// Creates a new CircularJoinableTaskDependencyDetectedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public CircularJoinableTaskDependencyDetectedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ReaderWriterLockIssued event.
        /// </summary>
        public readonly ref struct ReaderWriterLockIssuedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ReaderWriterLockIssued";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 1,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventType)Opcodes.ReaderWriterLockIssued,
                Task = (ushort)Tasks.LockRequest,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public ReaderWriterLockIssuedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ReaderWriterLockIssuedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ReaderWriterLockIssuedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ReaderWriterLockIssued event.
            /// </summary>
            public readonly ref struct ReaderWriterLockIssuedData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_LockId = 0;
                private const int Offset_Kind = 4;
                private const int Offset_IssuedUpgradeableReadCount = 8;
                private const int Offset_IssuedReadCount = 12;

                /// <summary>
                /// Retrieves the LockId field.
                /// </summary>
                public int LockId => BitConverter.ToInt32(_etwEvent.Data[Offset_LockId..Offset_Kind]);

                /// <summary>
                /// Retrieves the Kind field.
                /// </summary>
                public LockKind Kind => (LockKind)BitConverter.ToUInt32(_etwEvent.Data[Offset_Kind..Offset_IssuedUpgradeableReadCount]);

                /// <summary>
                /// Retrieves the IssuedUpgradeableReadCount field.
                /// </summary>
                public int IssuedUpgradeableReadCount => BitConverter.ToInt32(_etwEvent.Data[Offset_IssuedUpgradeableReadCount..Offset_IssuedReadCount]);

                /// <summary>
                /// Retrieves the IssuedReadCount field.
                /// </summary>
                public int IssuedReadCount => BitConverter.ToInt32(_etwEvent.Data[Offset_IssuedReadCount..]);

                /// <summary>
                /// Creates a new ReaderWriterLockIssuedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ReaderWriterLockIssuedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WaitReaderWriterLockStart event.
        /// </summary>
        public readonly ref struct WaitReaderWriterLockStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WaitReaderWriterLockStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 2,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventType.Start,
                Task = (ushort)Tasks.LockRequestContention,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public WaitReaderWriterLockStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WaitReaderWriterLockStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WaitReaderWriterLockStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WaitReaderWriterLockStart event.
            /// </summary>
            public readonly ref struct WaitReaderWriterLockStartData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_LockId = 0;
                private const int Offset_Kind = 4;
                private const int Offset_IssuedWriteCount = 8;
                private const int Offset_IssuedUpgradeableReadCount = 12;
                private const int Offset_IssuedReadCount = 16;

                /// <summary>
                /// Retrieves the LockId field.
                /// </summary>
                public int LockId => BitConverter.ToInt32(_etwEvent.Data[Offset_LockId..Offset_Kind]);

                /// <summary>
                /// Retrieves the Kind field.
                /// </summary>
                public LockKind Kind => (LockKind)BitConverter.ToUInt32(_etwEvent.Data[Offset_Kind..Offset_IssuedWriteCount]);

                /// <summary>
                /// Retrieves the IssuedWriteCount field.
                /// </summary>
                public int IssuedWriteCount => BitConverter.ToInt32(_etwEvent.Data[Offset_IssuedWriteCount..Offset_IssuedUpgradeableReadCount]);

                /// <summary>
                /// Retrieves the IssuedUpgradeableReadCount field.
                /// </summary>
                public int IssuedUpgradeableReadCount => BitConverter.ToInt32(_etwEvent.Data[Offset_IssuedUpgradeableReadCount..Offset_IssuedReadCount]);

                /// <summary>
                /// Retrieves the IssuedReadCount field.
                /// </summary>
                public int IssuedReadCount => BitConverter.ToInt32(_etwEvent.Data[Offset_IssuedReadCount..]);

                /// <summary>
                /// Creates a new WaitReaderWriterLockStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WaitReaderWriterLockStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WaitReaderWriterLockStop event.
        /// </summary>
        public readonly ref struct WaitReaderWriterLockStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WaitReaderWriterLockStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 3,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventType.Stop,
                Task = (ushort)Tasks.LockRequestContention,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public WaitReaderWriterLockStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WaitReaderWriterLockStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WaitReaderWriterLockStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WaitReaderWriterLockStop event.
            /// </summary>
            public readonly ref struct WaitReaderWriterLockStopData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_LockId = 0;
                private const int Offset_Kind = 4;

                /// <summary>
                /// Retrieves the LockId field.
                /// </summary>
                public int LockId => BitConverter.ToInt32(_etwEvent.Data[Offset_LockId..Offset_Kind]);

                /// <summary>
                /// Retrieves the Kind field.
                /// </summary>
                public LockKind Kind => (LockKind)BitConverter.ToUInt32(_etwEvent.Data[Offset_Kind..]);

                /// <summary>
                /// Creates a new WaitReaderWriterLockStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WaitReaderWriterLockStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a CompleteOnCurrentThreadStart event.
        /// </summary>
        public readonly ref struct CompleteOnCurrentThreadStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "CompleteOnCurrentThreadStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 11,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventType.Start,
                Task = (ushort)Tasks.CompleteOnCurrentThread,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public CompleteOnCurrentThreadStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new CompleteOnCurrentThreadStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public CompleteOnCurrentThreadStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a CompleteOnCurrentThreadStart event.
            /// </summary>
            public readonly ref struct CompleteOnCurrentThreadStartData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_TaskId = 0;
                private const int Offset_IsOnMainThread = 4;

                /// <summary>
                /// Retrieves the TaskId field.
                /// </summary>
                public int TaskId => BitConverter.ToInt32(_etwEvent.Data[Offset_TaskId..Offset_IsOnMainThread]);

                /// <summary>
                /// Retrieves the IsOnMainThread field.
                /// </summary>
                public bool IsOnMainThread => _etwEvent.Data[Offset_IsOnMainThread] != 0;

                /// <summary>
                /// Creates a new CompleteOnCurrentThreadStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public CompleteOnCurrentThreadStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a PostExecutionStart event.
        /// </summary>
        public readonly ref struct PostExecutionStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "PostExecutionStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 15,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventType.Start,
                Task = (ushort)Tasks.PostExecution,
                Keyword = 0
            };

            /// <summary>
            /// The process the event was recorded in.
            /// </summary>
            public uint ProcessId => _etwEvent.ProcessId;

            /// <summary>
            /// The thread the event was recorded on.
            /// </summary>
            public uint ThreadId => _etwEvent.ThreadId;

            /// <summary>
            /// The timestamp of the event.
            /// </summary>
            public long Timestamp => _etwEvent.Timestamp;

            /// <summary>
            /// The processor number the event was recorded on.
            /// </summary>
            public byte ProcessorNumber => _etwEvent.ProcessorNumber;

            /// <summary>
            /// Timing information for the event.
            /// </summary>
            public (ulong? KernelTime, ulong? UserTime, ulong? ProcessorTime) Time => _etwEvent.Time;

            /// <summary>
            /// Data for the event.
            /// </summary>
            public PostExecutionStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new PostExecutionStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public PostExecutionStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a PostExecutionStart event.
            /// </summary>
            public readonly ref struct PostExecutionStartData
            {
                private readonly EtwEvent _etwEvent;

                private const int Offset_RequestId = 0;
                private const int Offset_MainThreadAffinitized = 4;

                /// <summary>
                /// Retrieves the RequestId field.
                /// </summary>
                public int RequestId => BitConverter.ToInt32(_etwEvent.Data[Offset_RequestId..Offset_MainThreadAffinitized]);

                /// <summary>
                /// Retrieves the MainThreadAffinitized field.
                /// </summary>
                public bool MainThreadAffinitized => _etwEvent.Data[Offset_MainThreadAffinitized] != 0;

                /// <summary>
                /// Creates a new PostExecutionStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public PostExecutionStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                }
            }

        }

        /// <summary>
        /// Tasks supported by Microsoft-VisualStudio-Threading.
        /// </summary>
        public enum Tasks : ushort
        {
            /// <summary>
            /// 'LockRequest' task.
            /// </summary>
            LockRequest = 1,
            /// <summary>
            /// 'LockRequestContention' task.
            /// </summary>
            LockRequestContention = 2,
            /// <summary>
            /// 'CircularJoinableTaskDependencyDetected' task.
            /// </summary>
            CircularJoinableTaskDependencyDetected = 65517,
            /// <summary>
            /// 'PostExecutionStop' task.
            /// </summary>
            PostExecutionStop = 65518,
            /// <summary>
            /// 'PostExecution' task.
            /// </summary>
            PostExecution = 65519,
            /// <summary>
            /// 'WaitSynchronously' task.
            /// </summary>
            WaitSynchronously = 65521,
            /// <summary>
            /// 'CompleteOnCurrentThreadStop' task.
            /// </summary>
            CompleteOnCurrentThreadStop = 65522,
            /// <summary>
            /// 'CompleteOnCurrentThread' task.
            /// </summary>
            CompleteOnCurrentThread = 65523,
            /// <summary>
            /// 'EventSourceMessage' task.
            /// </summary>
            EventSourceMessage = 65534,
        }

        /// <summary>
        /// Opcodes supported by Microsoft-VisualStudio-Threading.
        /// </summary>
        public enum Opcodes
        {
            /// <summary>
            /// 'ReaderWriterLockWaiting' opcode.
            /// </summary>
            ReaderWriterLockWaiting = 100,
            /// <summary>
            /// 'ReaderWriterLockIssued' opcode.
            /// </summary>
            ReaderWriterLockIssued = 101,
            /// <summary>
            /// 'ReaderWriterLockIssuedAfterContention' opcode.
            /// </summary>
            ReaderWriterLockIssuedAfterContention = 102,
        }

        /// <summary>
        /// Keywords supported by Microsoft-VisualStudio-Threading.
        /// </summary>
        [Flags]
        public enum Keywords : ulong
        {
            /// <summary>
            /// 'Session3' keyword.
            /// </summary>
            Session3 = 0x0000100000000000,
            /// <summary>
            /// 'Session2' keyword.
            /// </summary>
            Session2 = 0x0000200000000000,
            /// <summary>
            /// 'Session1' keyword.
            /// </summary>
            Session1 = 0x0000400000000000,
            /// <summary>
            /// 'Session0' keyword.
            /// </summary>
            Session0 = 0x0000800000000000,
        }

        /// <summary>
        /// LockKind.
        /// </summary>
        public enum LockKind
        {
            /// <summary>
            /// Read.
            /// </summary>
            Read = 0,
            /// <summary>
            /// UpgradeableRead.
            /// </summary>
            UpgradeableRead = 1,
            /// <summary>
            /// Write.
            /// </summary>
            Write = 2,
        }
    }
}
