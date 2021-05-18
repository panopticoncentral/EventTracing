using System;

#pragma warning disable IDE0004 // Remove Unnecessary Cast
#pragma warning disable CA1707 // Identifiers should not contain underscores
#pragma warning disable CA1720 // Identifier contains type name

namespace EtwTools
{
    /// <summary>
    /// Provider for Microsoft-Windows-DotNETRuntime (e13c0d23-ccbc-4e12-931b-d9cc2eee27e4)
    /// </summary>
    public sealed class DotnetRuntimeProvider
    {
        /// <summary>s
        /// Provider ID.
        /// </summary>
        public static readonly Guid Id = new("e13c0d23-ccbc-4e12-931b-d9cc2eee27e4");

        /// <summary>
        /// Provider name.
        /// </summary>
        public const string Name = "Microsoft-Windows-DotNETRuntime";

        /// <summary>
        /// Tasks supported by Microsoft-Windows-DotNETRuntime.
        /// </summary>
        public enum Tasks : ushort
        {
            /// <summary>
            /// 'GC' task.
            /// </summary>
            GC = 1,
            /// <summary>
            /// 'WorkerThreadCreationV2' task.
            /// </summary>
            WorkerThreadCreationV2 = 2,
            /// <summary>
            /// 'IOThreadCreation' task.
            /// </summary>
            IOThreadCreation = 3,
            /// <summary>
            /// 'WorkerThreadRetirementV2' task.
            /// </summary>
            WorkerThreadRetirementV2 = 4,
            /// <summary>
            /// 'IOThreadRetirement' task.
            /// </summary>
            IOThreadRetirement = 5,
            /// <summary>
            /// 'ThreadpoolSuspensionV2' task.
            /// </summary>
            ThreadpoolSuspensionV2 = 6,
            /// <summary>
            /// 'Exception' task.
            /// </summary>
            Exception = 7,
            /// <summary>
            /// 'Contention' task.
            /// </summary>
            Contention = 8,
            /// <summary>
            /// 'Method' task.
            /// </summary>
            Method = 9,
            /// <summary>
            /// 'Loader' task.
            /// </summary>
            Loader = 10,
            /// <summary>
            /// 'ClrStack' task.
            /// </summary>
            ClrStack = 11,
            /// <summary>
            /// 'StrongNameVerification' task.
            /// </summary>
            StrongNameVerification = 12,
            /// <summary>
            /// 'AuthenticodeVerification' task.
            /// </summary>
            AuthenticodeVerification = 13,
            /// <summary>
            /// 'AppDomainResourceManagement' task.
            /// </summary>
            AppDomainResourceManagement = 14,
            /// <summary>
            /// 'ILStub' task.
            /// </summary>
            ILStub = 15,
            /// <summary>
            /// 'ThreadPoolWorkerThread' task.
            /// </summary>
            ThreadPoolWorkerThread = 16,
            /// <summary>
            /// 'ThreadPoolWorkerThreadRetirement' task.
            /// </summary>
            ThreadPoolWorkerThreadRetirement = 17,
            /// <summary>
            /// 'ThreadPoolWorkerThreadAdjustment' task.
            /// </summary>
            ThreadPoolWorkerThreadAdjustment = 18,
            /// <summary>
            /// 'Runtime' task.
            /// </summary>
            Runtime = 19,
            /// <summary>
            /// 'ClrPerfTrack' task.
            /// </summary>
            ClrPerfTrack = 20,
            /// <summary>
            /// 'Type' task.
            /// </summary>
            Type = 21,
            /// <summary>
            /// 'ThreadPoolWorkingThreadCount' task.
            /// </summary>
            ThreadPoolWorkingThreadCount = 22,
            /// <summary>
            /// 'ThreadPool' task.
            /// </summary>
            ThreadPool = 23,
            /// <summary>
            /// 'Thread' task.
            /// </summary>
            Thread = 24,
            /// <summary>
            /// 'DebugIPCEvent' task.
            /// </summary>
            DebugIPCEvent = 25,
            /// <summary>
            /// 'DebugExceptionProcessing' task.
            /// </summary>
            DebugExceptionProcessing = 26,
            /// <summary>
            /// 'ExceptionCatch' task.
            /// </summary>
            ExceptionCatch = 27,
            /// <summary>
            /// 'ExceptionFinally' task.
            /// </summary>
            ExceptionFinally = 28,
            /// <summary>
            /// 'ExceptionFilter' task.
            /// </summary>
            ExceptionFilter = 29,
        }

        /// <summary>
        /// Opcodes supported by DotnetRuntime.
        /// </summary>
        public enum Opcodes
        {
            /// <summary>
            /// 'SuspendEEStart' opcode.
            /// </summary>
            SuspendEEStart = 10,
            /// <summary>
            /// 'AllocationTick' opcode.
            /// </summary>
            AllocationTick = 11,
            /// <summary>
            /// 'CreateConcurrentThread' opcode.
            /// </summary>
            CreateConcurrentThread = 12,
            /// <summary>
            /// 'TerminateConcurrentThread' opcode.
            /// </summary>
            TerminateConcurrentThread = 13,
            /// <summary>
            /// 'IODequeue' opcode.
            /// </summary>
            IODequeue = 14,
            /// <summary>
            /// 'FinalizersStop' opcode.
            /// </summary>
            FinalizersStop = 15,
            /// <summary>
            /// 'FinalizersStart' opcode.
            /// </summary>
            FinalizersStart = 19,
            /// <summary>
            /// 'GCBulkRootEdge' opcode.
            /// </summary>
            GCBulkRootEdge = 20,
            /// <summary>
            /// 'GCBulkRootConditionalWeakTableElementEdge' opcode.
            /// </summary>
            GCBulkRootConditionalWeakTableElementEdge = 21,
            /// <summary>
            /// 'GCBulkNode' opcode.
            /// </summary>
            GCBulkNode = 22,
            /// <summary>
            /// 'GCBulkEdge' opcode.
            /// </summary>
            GCBulkEdge = 23,
            /// <summary>
            /// 'GCSampledObjectAllocation' opcode.
            /// </summary>
            GCSampledObjectAllocation = 24,
            /// <summary>
            /// 'GCBulkSurvivingObjectRanges' opcode.
            /// </summary>
            GCBulkSurvivingObjectRanges = 25,
            /// <summary>
            /// 'GCBulkMovedObjectRanges' opcode.
            /// </summary>
            GCBulkMovedObjectRanges = 26,
            /// <summary>
            /// 'GCGenerationRange' opcode.
            /// </summary>
            GCGenerationRange = 27,
            /// <summary>
            /// 'MarkStackRoots' opcode.
            /// </summary>
            MarkStackRoots = 28,
            /// <summary>
            /// 'MarkFinalizeQueueRoots' opcode.
            /// </summary>
            MarkFinalizeQueueRoots = 29,
            /// <summary>
            /// 'MarkHandles' opcode.
            /// </summary>
            MarkHandles = 30,
            /// <summary>
            /// 'MarkCards' opcode.
            /// </summary>
            MarkCards = 31,
            /// <summary>
            /// 'FinalizeObject' opcode.
            /// </summary>
            FinalizeObject = 32,
            /// <summary>
            /// 'SetGCHandle' opcode.
            /// </summary>
            SetGCHandle = 33,
            /// <summary>
            /// 'DestoryGCHandle' opcode.
            /// </summary>
            DestoryGCHandle = 34,
            /// <summary>
            /// 'Triggered' opcode.
            /// </summary>
            Triggered = 35,
            /// <summary>
            /// 'PinObjectAtGCTime' opcode.
            /// </summary>
            PinObjectAtGCTime = 36,
            /// <summary>
            /// 'LoadVerbose' opcode.
            /// </summary>
            LoadVerbose = 37,
            /// <summary>
            /// 'GCBulkRootCCW' opcode.
            /// </summary>
            GCBulkRootCCW = 38,
            /// <summary>
            /// 'GCBulkRCW' opcode.
            /// </summary>
            GCBulkRCW = 39,
            /// <summary>
            /// 'GCBulkRootStaticVar' opcode.
            /// </summary>
            GCBulkRootStaticVar = 40,
            /// <summary>
            /// 'GCDynamicEvent' opcode.
            /// </summary>
            GCDynamicEvent = 41,
            /// <summary>
            /// 'JittingStarted' opcode.
            /// </summary>
            JittingStarted = 42,
            /// <summary>
            /// 'DomainModuleLoad' opcode.
            /// </summary>
            DomainModuleLoad = 45,
            /// <summary>
            /// 'MemAllocated' opcode.
            /// </summary>
            MemAllocated = 48,
            /// <summary>
            /// 'MemSurvived' opcode.
            /// </summary>
            MemSurvived = 49,
            /// <summary>
            /// 'ThreadCreated' opcode.
            /// </summary>
            ThreadCreated = 50,
            /// <summary>
            /// 'ThreadTerminated' opcode.
            /// </summary>
            ThreadTerminated = 51,
            /// <summary>
            /// 'DomainEnter' opcode.
            /// </summary>
            DomainEnter = 52,
            /// <summary>
            /// 'Walk' opcode.
            /// </summary>
            Walk = 82,
            /// <summary>
            /// 'InliningSucceeded' opcode.
            /// </summary>
            InliningSucceeded = 83,
            /// <summary>
            /// 'InliningFailed' opcode.
            /// </summary>
            InliningFailed = 84,
            /// <summary>
            /// 'TailCallSucceeded' opcode.
            /// </summary>
            TailCallSucceeded = 85,
            /// <summary>
            /// 'TailCallFailed' opcode.
            /// </summary>
            TailCallFailed = 86,
            /// <summary>
            /// 'MethodILToNativeMap' opcode.
            /// </summary>
            MethodILToNativeMap = 87,
            /// <summary>
            /// 'StubGenerated' opcode.
            /// </summary>
            StubGenerated = 88,
            /// <summary>
            /// 'StubCacheHit' opcode.
            /// </summary>
            StubCacheHit = 89,
            /// <summary>
            /// 'Wait' opcode.
            /// </summary>
            Wait = 90,
            /// <summary>
            /// 'Sample' opcode.
            /// </summary>
            Sample = 100,
            /// <summary>
            /// 'Adjustment' opcode.
            /// </summary>
            Adjustment = 101,
            /// <summary>
            /// 'Stats' opcode.
            /// </summary>
            Stats = 102,
            /// <summary>
            /// 'RestartEEStop' opcode.
            /// </summary>
            RestartEEStop = 132,
            /// <summary>
            /// 'HeapStats' opcode.
            /// </summary>
            HeapStats = 133,
            /// <summary>
            /// 'CreateSegment' opcode.
            /// </summary>
            CreateSegment = 134,
            /// <summary>
            /// 'FreeSegment' opcode.
            /// </summary>
            FreeSegment = 135,
            /// <summary>
            /// 'RestartEEStart' opcode.
            /// </summary>
            RestartEEStart = 136,
            /// <summary>
            /// 'SuspendEEStop' opcode.
            /// </summary>
            SuspendEEStop = 137,
            /// <summary>
            /// 'IncreaseMemoryPressure' opcode.
            /// </summary>
            IncreaseMemoryPressure = 200,
            /// <summary>
            /// 'DecreaseMemoryPressure' opcode.
            /// </summary>
            DecreaseMemoryPressure = 201,
            /// <summary>
            /// 'Mark' opcode.
            /// </summary>
            Mark = 202,
            /// <summary>
            /// 'GCJoin' opcode.
            /// </summary>
            GCJoin = 203,
            /// <summary>
            /// 'PerHeapHistory' opcode.
            /// </summary>
            PerHeapHistory = 204,
            /// <summary>
            /// 'GlobalHeapHistory' opcode.
            /// </summary>
            GlobalHeapHistory = 205,
            /// <summary>
            /// 'GCLoaded' opcode.
            /// </summary>
            GCLoaded = 206,
        }

        /// <summary>
        /// Keywords supported by DotnetRuntime.
        /// </summary>
        [Flags]
        public enum Keywords : ulong
        {
            /// <summary>
            /// 'GCKeyword' keyword.
            /// </summary>
            GCKeyword = 0x0000000000000001,
            /// <summary>
            /// 'GCHandleKeyword' keyword.
            /// </summary>
            GCHandleKeyword = 0x0000000000000002,
            /// <summary>
            /// 'FusionKeyword' keyword.
            /// </summary>
            FusionKeyword = 0x0000000000000004,
            /// <summary>
            /// 'LoaderKeyword' keyword.
            /// </summary>
            LoaderKeyword = 0x0000000000000008,
            /// <summary>
            /// 'JitKeyword' keyword.
            /// </summary>
            JitKeyword = 0x0000000000000010,
            /// <summary>
            /// 'NGenKeyword' keyword.
            /// </summary>
            NGenKeyword = 0x0000000000000020,
            /// <summary>
            /// 'StartEnumerationKeyword' keyword.
            /// </summary>
            StartEnumerationKeyword = 0x0000000000000040,
            /// <summary>
            /// 'EndEnumerationKeyword' keyword.
            /// </summary>
            EndEnumerationKeyword = 0x0000000000000080,
            /// <summary>
            /// 'SecurityKeyword' keyword.
            /// </summary>
            SecurityKeyword = 0x0000000000000400,
            /// <summary>
            /// 'AppDomainResourceManagementKeyword' keyword.
            /// </summary>
            AppDomainResourceManagementKeyword = 0x0000000000000800,
            /// <summary>
            /// 'JitTracingKeyword' keyword.
            /// </summary>
            JitTracingKeyword = 0x0000000000001000,
            /// <summary>
            /// 'InteropKeyword' keyword.
            /// </summary>
            InteropKeyword = 0x0000000000002000,
            /// <summary>
            /// 'ContentionKeyword' keyword.
            /// </summary>
            ContentionKeyword = 0x0000000000004000,
            /// <summary>
            /// 'ExceptionKeyword' keyword.
            /// </summary>
            ExceptionKeyword = 0x0000000000008000,
            /// <summary>
            /// 'ThreadingKeyword' keyword.
            /// </summary>
            ThreadingKeyword = 0x0000000000010000,
            /// <summary>
            /// 'JittedMethodILToNativeMapKeyword' keyword.
            /// </summary>
            JittedMethodILToNativeMapKeyword = 0x0000000000020000,
            /// <summary>
            /// 'OverrideAndSuppressNGenEventsKeyword' keyword.
            /// </summary>
            OverrideAndSuppressNGenEventsKeyword = 0x0000000000040000,
            /// <summary>
            /// 'TypeKeyword' keyword.
            /// </summary>
            TypeKeyword = 0x0000000000080000,
            /// <summary>
            /// 'GCHeapDumpKeyword' keyword.
            /// </summary>
            GCHeapDumpKeyword = 0x0000000000100000,
            /// <summary>
            /// 'GCSampledObjectAllocationHighKeyword' keyword.
            /// </summary>
            GCSampledObjectAllocationHighKeyword = 0x0000000000200000,
            /// <summary>
            /// 'GCHeapSurvivalAndMovementKeyword' keyword.
            /// </summary>
            GCHeapSurvivalAndMovementKeyword = 0x0000000000400000,
            /// <summary>
            /// 'GCHeapCollectKeyword' keyword.
            /// </summary>
            GCHeapCollectKeyword = 0x0000000000800000,
            /// <summary>
            /// 'GCHeapAndTypeNamesKeyword' keyword.
            /// </summary>
            GCHeapAndTypeNamesKeyword = 0x0000000001000000,
            /// <summary>
            /// 'GCSampledObjectAllocationLowKeyword' keyword.
            /// </summary>
            GCSampledObjectAllocationLowKeyword = 0x0000000002000000,
            /// <summary>
            /// 'PerfTrackKeyword' keyword.
            /// </summary>
            PerfTrackKeyword = 0x0000000020000000,
            /// <summary>
            /// 'StackKeyword' keyword.
            /// </summary>
            StackKeyword = 0x0000000040000000,
            /// <summary>
            /// 'ThreadTransferKeyword' keyword.
            /// </summary>
            ThreadTransferKeyword = 0x0000000080000000,
            /// <summary>
            /// 'DebuggerKeyword' keyword.
            /// </summary>
            DebuggerKeyword = 0x0000000100000000,
            /// <summary>
            /// 'MonitoringKeyword' keyword.
            /// </summary>
            MonitoringKeyword = 0x0000000200000000,
        }

        /// <summary>
        /// An event wrapper for a TypeBulkType event.
        /// </summary>
        public readonly ref struct TypeBulkTypeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "TypeBulkType";

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
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SuspendEEStart,
                Task = (ushort)Tasks.Type,
                Keyword = (ulong)Keywords.TypeKeyword
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
            public TypeBulkTypeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new TypeBulkTypeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public TypeBulkTypeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a TypeBulkType event.
            /// </summary>
            public ref struct TypeBulkTypeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public TypeBulkTypeValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new TypeBulkTypeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public TypeBulkTypeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkRootEdge event.
        /// </summary>
        public readonly ref struct GCBulkRootEdgeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkRootEdge";

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
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootEdge,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkRootEdgeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkRootEdgeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkRootEdgeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkRootEdge event.
            /// </summary>
            public ref struct GCBulkRootEdgeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkRootEdgeValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkRootEdgeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkRootEdgeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkRootConditionalWeakTableElementEdge event.
        /// </summary>
        public readonly ref struct GCBulkRootConditionalWeakTableElementEdgeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkRootConditionalWeakTableElementEdge";

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
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootConditionalWeakTableElementEdge,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkRootConditionalWeakTableElementEdgeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkRootConditionalWeakTableElementEdgeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkRootConditionalWeakTableElementEdgeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkRootConditionalWeakTableElementEdge event.
            /// </summary>
            public ref struct GCBulkRootConditionalWeakTableElementEdgeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkRootConditionalWeakTableElementEdgeValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkRootConditionalWeakTableElementEdgeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkRootConditionalWeakTableElementEdgeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkNode event.
        /// </summary>
        public readonly ref struct GCBulkNodeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkNode";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 18,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkNode,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkNodeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkNodeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkNodeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkNode event.
            /// </summary>
            public ref struct GCBulkNodeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkNodeValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkNodeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkNodeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkEdge event.
        /// </summary>
        public readonly ref struct GCBulkEdgeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkEdge";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 19,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkEdge,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkEdgeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkEdgeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkEdgeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkEdge event.
            /// </summary>
            public ref struct GCBulkEdgeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkEdgeValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkEdgeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkEdgeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCSampledObjectAllocationHigh event.
        /// </summary>
        public readonly ref struct GCSampledObjectAllocationHighEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCSampledObjectAllocationHigh";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 20,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCSampledObjectAllocation,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCSampledObjectAllocationHighKeyword
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
            public GCSampledObjectAllocationHighData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCSampledObjectAllocationHighEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCSampledObjectAllocationHighEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCSampledObjectAllocationHigh event.
            /// </summary>
            public ref struct GCSampledObjectAllocationHighData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Address;
                private int _offset_TypeID;
                private int _offset_ObjectCountForTypeSample;
                private int _offset_TotalSizeForTypeSample;
                private int _offset_ClrInstanceID;

                private int Offset_Address
                {
                    get
                    {
                        if (_offset_Address == -1)
                        {
                            _offset_Address = 0;
                        }

                        return _offset_Address;
                    }
                }

                private int Offset_TypeID
                {
                    get
                    {
                        if (_offset_TypeID == -1)
                        {
                            _offset_TypeID = Offset_Address + _etwEvent.AddressSize;
                        }

                        return _offset_TypeID;
                    }
                }

                private int Offset_ObjectCountForTypeSample
                {
                    get
                    {
                        if (_offset_ObjectCountForTypeSample == -1)
                        {
                            _offset_ObjectCountForTypeSample = Offset_TypeID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectCountForTypeSample;
                    }
                }

                private int Offset_TotalSizeForTypeSample
                {
                    get
                    {
                        if (_offset_TotalSizeForTypeSample == -1)
                        {
                            _offset_TotalSizeForTypeSample = Offset_ObjectCountForTypeSample + 4;
                        }

                        return _offset_TotalSizeForTypeSample;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_TotalSizeForTypeSample + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Address field.
                /// </summary>
                public ulong Address => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Address..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

                /// <summary>
                /// Retrieves the TypeID field.
                /// </summary>
                public ulong TypeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

                /// <summary>
                /// Retrieves the ObjectCountForTypeSample field.
                /// </summary>
                public uint ObjectCountForTypeSample => BitConverter.ToUInt32(_etwEvent.Data[Offset_ObjectCountForTypeSample..]);

                /// <summary>
                /// Retrieves the TotalSizeForTypeSample field.
                /// </summary>
                public ulong TotalSizeForTypeSample => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalSizeForTypeSample..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCSampledObjectAllocationHighData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCSampledObjectAllocationHighData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Address = -1;
                    _offset_TypeID = -1;
                    _offset_ObjectCountForTypeSample = -1;
                    _offset_TotalSizeForTypeSample = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkSurvivingObjectRanges event.
        /// </summary>
        public readonly ref struct GCBulkSurvivingObjectRangesEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkSurvivingObjectRanges";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 21,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkSurvivingObjectRanges,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapSurvivalAndMovementKeyword
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
            public GCBulkSurvivingObjectRangesData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkSurvivingObjectRangesEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkSurvivingObjectRangesEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkSurvivingObjectRanges event.
            /// </summary>
            public ref struct GCBulkSurvivingObjectRangesData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkSurvivingObjectRangesValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkSurvivingObjectRangesData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkSurvivingObjectRangesData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkMovedObjectRanges event.
        /// </summary>
        public readonly ref struct GCBulkMovedObjectRangesEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkMovedObjectRanges";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 22,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkMovedObjectRanges,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapSurvivalAndMovementKeyword
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
            public GCBulkMovedObjectRangesData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkMovedObjectRangesEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkMovedObjectRangesEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkMovedObjectRanges event.
            /// </summary>
            public ref struct GCBulkMovedObjectRangesData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Index;
                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Index
                {
                    get
                    {
                        if (_offset_Index == -1)
                        {
                            _offset_Index = 0;
                        }

                        return _offset_Index;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Index + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Index field.
                /// </summary>
                public uint Index => BitConverter.ToUInt32(_etwEvent.Data[Offset_Index..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkMovedObjectRangesValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkMovedObjectRangesData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkMovedObjectRangesData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Index = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCGenerationRange event.
        /// </summary>
        public readonly ref struct GCGenerationRangeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCGenerationRange";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 23,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCGenerationRange,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapSurvivalAndMovementKeyword
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
            public GCGenerationRangeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCGenerationRangeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCGenerationRangeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCGenerationRange event.
            /// </summary>
            public ref struct GCGenerationRangeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Generation;
                private int _offset_RangeStart;
                private int _offset_RangeUsedLength;
                private int _offset_RangeReservedLength;
                private int _offset_ClrInstanceID;

                private int Offset_Generation
                {
                    get
                    {
                        if (_offset_Generation == -1)
                        {
                            _offset_Generation = 0;
                        }

                        return _offset_Generation;
                    }
                }

                private int Offset_RangeStart
                {
                    get
                    {
                        if (_offset_RangeStart == -1)
                        {
                            _offset_RangeStart = Offset_Generation + 1;
                        }

                        return _offset_RangeStart;
                    }
                }

                private int Offset_RangeUsedLength
                {
                    get
                    {
                        if (_offset_RangeUsedLength == -1)
                        {
                            _offset_RangeUsedLength = Offset_RangeStart + _etwEvent.AddressSize;
                        }

                        return _offset_RangeUsedLength;
                    }
                }

                private int Offset_RangeReservedLength
                {
                    get
                    {
                        if (_offset_RangeReservedLength == -1)
                        {
                            _offset_RangeReservedLength = Offset_RangeUsedLength + 8;
                        }

                        return _offset_RangeReservedLength;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RangeReservedLength + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Generation field.
                /// </summary>
                public byte Generation => _etwEvent.Data[Offset_Generation];

                /// <summary>
                /// Retrieves the RangeStart field.
                /// </summary>
                public ulong RangeStart => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_RangeStart..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeStart..]);

                /// <summary>
                /// Retrieves the RangeUsedLength field.
                /// </summary>
                public ulong RangeUsedLength => BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeUsedLength..]);

                /// <summary>
                /// Retrieves the RangeReservedLength field.
                /// </summary>
                public ulong RangeReservedLength => BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeReservedLength..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCGenerationRangeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCGenerationRangeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Generation = -1;
                    _offset_RangeStart = -1;
                    _offset_RangeUsedLength = -1;
                    _offset_RangeReservedLength = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCMarkStackRoots event.
        /// </summary>
        public readonly ref struct GCMarkStackRootsEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCMarkStackRoots";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 25,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MarkStackRoots,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCMarkStackRootsData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCMarkStackRootsEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCMarkStackRootsEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCMarkStackRoots event.
            /// </summary>
            public ref struct GCMarkStackRootsData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HeapNum;
                private int _offset_ClrInstanceID;

                private int Offset_HeapNum
                {
                    get
                    {
                        if (_offset_HeapNum == -1)
                        {
                            _offset_HeapNum = 0;
                        }

                        return _offset_HeapNum;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HeapNum + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HeapNum field.
                /// </summary>
                public uint HeapNum => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapNum..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCMarkStackRootsData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCMarkStackRootsData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HeapNum = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCMarkFinalizeQueueRoots event.
        /// </summary>
        public readonly ref struct GCMarkFinalizeQueueRootsEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCMarkFinalizeQueueRoots";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 26,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MarkFinalizeQueueRoots,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCMarkFinalizeQueueRootsData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCMarkFinalizeQueueRootsEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCMarkFinalizeQueueRootsEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCMarkFinalizeQueueRoots event.
            /// </summary>
            public ref struct GCMarkFinalizeQueueRootsData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HeapNum;
                private int _offset_ClrInstanceID;

                private int Offset_HeapNum
                {
                    get
                    {
                        if (_offset_HeapNum == -1)
                        {
                            _offset_HeapNum = 0;
                        }

                        return _offset_HeapNum;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HeapNum + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HeapNum field.
                /// </summary>
                public uint HeapNum => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapNum..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCMarkFinalizeQueueRootsData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCMarkFinalizeQueueRootsData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HeapNum = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCMarkHandles event.
        /// </summary>
        public readonly ref struct GCMarkHandlesEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCMarkHandles";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 27,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MarkHandles,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCMarkHandlesData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCMarkHandlesEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCMarkHandlesEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCMarkHandles event.
            /// </summary>
            public ref struct GCMarkHandlesData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HeapNum;
                private int _offset_ClrInstanceID;

                private int Offset_HeapNum
                {
                    get
                    {
                        if (_offset_HeapNum == -1)
                        {
                            _offset_HeapNum = 0;
                        }

                        return _offset_HeapNum;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HeapNum + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HeapNum field.
                /// </summary>
                public uint HeapNum => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapNum..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCMarkHandlesData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCMarkHandlesData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HeapNum = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCMarkCards event.
        /// </summary>
        public readonly ref struct GCMarkCardsEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCMarkCards";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 28,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MarkCards,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCMarkCardsData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCMarkCardsEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCMarkCardsEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCMarkCards event.
            /// </summary>
            public ref struct GCMarkCardsData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HeapNum;
                private int _offset_ClrInstanceID;

                private int Offset_HeapNum
                {
                    get
                    {
                        if (_offset_HeapNum == -1)
                        {
                            _offset_HeapNum = 0;
                        }

                        return _offset_HeapNum;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HeapNum + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HeapNum field.
                /// </summary>
                public uint HeapNum => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapNum..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCMarkCardsData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCMarkCardsData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HeapNum = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCFinalizeObject event.
        /// </summary>
        public readonly ref struct GCFinalizeObjectEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCFinalizeObject";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 29,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.FinalizeObject,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCFinalizeObjectData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCFinalizeObjectEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCFinalizeObjectEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCFinalizeObject event.
            /// </summary>
            public ref struct GCFinalizeObjectData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_TypeID;
                private int _offset_ObjectID;
                private int _offset_ClrInstanceID;

                private int Offset_TypeID
                {
                    get
                    {
                        if (_offset_TypeID == -1)
                        {
                            _offset_TypeID = 0;
                        }

                        return _offset_TypeID;
                    }
                }

                private int Offset_ObjectID
                {
                    get
                    {
                        if (_offset_ObjectID == -1)
                        {
                            _offset_ObjectID = Offset_TypeID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ObjectID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the TypeID field.
                /// </summary>
                public ulong TypeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

                /// <summary>
                /// Retrieves the ObjectID field.
                /// </summary>
                public ulong ObjectID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ObjectID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCFinalizeObjectData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCFinalizeObjectData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_TypeID = -1;
                    _offset_ObjectID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCSetGCHandle event.
        /// </summary>
        public readonly ref struct GCSetGCHandleEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCSetGCHandle";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 30,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SetGCHandle,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHandleKeyword
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
            public GCSetGCHandleData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCSetGCHandleEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCSetGCHandleEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCSetGCHandle event.
            /// </summary>
            public ref struct GCSetGCHandleData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HandleID;
                private int _offset_ObjectID;
                private int _offset_Kind;
                private int _offset_Generation;
                private int _offset_AppDomainID;
                private int _offset_ClrInstanceID;

                private int Offset_HandleID
                {
                    get
                    {
                        if (_offset_HandleID == -1)
                        {
                            _offset_HandleID = 0;
                        }

                        return _offset_HandleID;
                    }
                }

                private int Offset_ObjectID
                {
                    get
                    {
                        if (_offset_ObjectID == -1)
                        {
                            _offset_ObjectID = Offset_HandleID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectID;
                    }
                }

                private int Offset_Kind
                {
                    get
                    {
                        if (_offset_Kind == -1)
                        {
                            _offset_Kind = Offset_ObjectID + _etwEvent.AddressSize;
                        }

                        return _offset_Kind;
                    }
                }

                private int Offset_Generation
                {
                    get
                    {
                        if (_offset_Generation == -1)
                        {
                            _offset_Generation = Offset_Kind + 4;
                        }

                        return _offset_Generation;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_Generation + 4;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainID + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HandleID field.
                /// </summary>
                public ulong HandleID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_HandleID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_HandleID..]);

                /// <summary>
                /// Retrieves the ObjectID field.
                /// </summary>
                public ulong ObjectID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ObjectID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

                /// <summary>
                /// Retrieves the Kind field.
                /// </summary>
                public GCHandleKindMap Kind => (GCHandleKindMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Kind..]);

                /// <summary>
                /// Retrieves the Generation field.
                /// </summary>
                public uint Generation => BitConverter.ToUInt32(_etwEvent.Data[Offset_Generation..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCSetGCHandleData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCSetGCHandleData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HandleID = -1;
                    _offset_ObjectID = -1;
                    _offset_Kind = -1;
                    _offset_Generation = -1;
                    _offset_AppDomainID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCDestoryGCHandle event.
        /// </summary>
        public readonly ref struct GCDestoryGCHandleEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCDestoryGCHandle";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 31,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.DestoryGCHandle,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHandleKeyword
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
            public GCDestoryGCHandleData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCDestoryGCHandleEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCDestoryGCHandleEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCDestoryGCHandle event.
            /// </summary>
            public ref struct GCDestoryGCHandleData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HandleID;
                private int _offset_ClrInstanceID;

                private int Offset_HandleID
                {
                    get
                    {
                        if (_offset_HandleID == -1)
                        {
                            _offset_HandleID = 0;
                        }

                        return _offset_HandleID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HandleID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HandleID field.
                /// </summary>
                public ulong HandleID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_HandleID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_HandleID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCDestoryGCHandleData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCDestoryGCHandleData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HandleID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCSampledObjectAllocationLow event.
        /// </summary>
        public readonly ref struct GCSampledObjectAllocationLowEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCSampledObjectAllocationLow";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 32,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCSampledObjectAllocation,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCSampledObjectAllocationLowKeyword
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
            public GCSampledObjectAllocationLowData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCSampledObjectAllocationLowEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCSampledObjectAllocationLowEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCSampledObjectAllocationLow event.
            /// </summary>
            public ref struct GCSampledObjectAllocationLowData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Address;
                private int _offset_TypeID;
                private int _offset_ObjectCountForTypeSample;
                private int _offset_TotalSizeForTypeSample;
                private int _offset_ClrInstanceID;

                private int Offset_Address
                {
                    get
                    {
                        if (_offset_Address == -1)
                        {
                            _offset_Address = 0;
                        }

                        return _offset_Address;
                    }
                }

                private int Offset_TypeID
                {
                    get
                    {
                        if (_offset_TypeID == -1)
                        {
                            _offset_TypeID = Offset_Address + _etwEvent.AddressSize;
                        }

                        return _offset_TypeID;
                    }
                }

                private int Offset_ObjectCountForTypeSample
                {
                    get
                    {
                        if (_offset_ObjectCountForTypeSample == -1)
                        {
                            _offset_ObjectCountForTypeSample = Offset_TypeID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectCountForTypeSample;
                    }
                }

                private int Offset_TotalSizeForTypeSample
                {
                    get
                    {
                        if (_offset_TotalSizeForTypeSample == -1)
                        {
                            _offset_TotalSizeForTypeSample = Offset_ObjectCountForTypeSample + 4;
                        }

                        return _offset_TotalSizeForTypeSample;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_TotalSizeForTypeSample + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Address field.
                /// </summary>
                public ulong Address => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Address..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

                /// <summary>
                /// Retrieves the TypeID field.
                /// </summary>
                public ulong TypeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

                /// <summary>
                /// Retrieves the ObjectCountForTypeSample field.
                /// </summary>
                public uint ObjectCountForTypeSample => BitConverter.ToUInt32(_etwEvent.Data[Offset_ObjectCountForTypeSample..]);

                /// <summary>
                /// Retrieves the TotalSizeForTypeSample field.
                /// </summary>
                public ulong TotalSizeForTypeSample => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalSizeForTypeSample..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCSampledObjectAllocationLowData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCSampledObjectAllocationLowData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Address = -1;
                    _offset_TypeID = -1;
                    _offset_ObjectCountForTypeSample = -1;
                    _offset_TotalSizeForTypeSample = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCPinObjectAtGCTime event.
        /// </summary>
        public readonly ref struct GCPinObjectAtGCTimeEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCPinObjectAtGCTime";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 33,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.PinObjectAtGCTime,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCPinObjectAtGCTimeData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCPinObjectAtGCTimeEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCPinObjectAtGCTimeEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCPinObjectAtGCTime event.
            /// </summary>
            public ref struct GCPinObjectAtGCTimeData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HandleID;
                private int _offset_ObjectID;
                private int _offset_ObjectSize;
                private int _offset_TypeName;
                private int _offset_ClrInstanceID;

                private int Offset_HandleID
                {
                    get
                    {
                        if (_offset_HandleID == -1)
                        {
                            _offset_HandleID = 0;
                        }

                        return _offset_HandleID;
                    }
                }

                private int Offset_ObjectID
                {
                    get
                    {
                        if (_offset_ObjectID == -1)
                        {
                            _offset_ObjectID = Offset_HandleID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectID;
                    }
                }

                private int Offset_ObjectSize
                {
                    get
                    {
                        if (_offset_ObjectSize == -1)
                        {
                            _offset_ObjectSize = Offset_ObjectID + _etwEvent.AddressSize;
                        }

                        return _offset_ObjectSize;
                    }
                }

                private int Offset_TypeName
                {
                    get
                    {
                        if (_offset_TypeName == -1)
                        {
                            _offset_TypeName = Offset_ObjectSize + 8;
                        }

                        return _offset_TypeName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_TypeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_TypeName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the HandleID field.
                /// </summary>
                public ulong HandleID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_HandleID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_HandleID..]);

                /// <summary>
                /// Retrieves the ObjectID field.
                /// </summary>
                public ulong ObjectID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ObjectID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

                /// <summary>
                /// Retrieves the ObjectSize field.
                /// </summary>
                public ulong ObjectSize => BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectSize..]);

                /// <summary>
                /// Retrieves the TypeName field.
                /// </summary>
                public string TypeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_TypeName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCPinObjectAtGCTimeData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCPinObjectAtGCTimeData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HandleID = -1;
                    _offset_ObjectID = -1;
                    _offset_ObjectSize = -1;
                    _offset_TypeName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCTriggered event.
        /// </summary>
        public readonly ref struct GCTriggeredEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCTriggered";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 35,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Triggered,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCTriggeredData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCTriggeredEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCTriggeredEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCTriggered event.
            /// </summary>
            public ref struct GCTriggeredData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Reason;
                private int _offset_ClrInstanceID;

                private int Offset_Reason
                {
                    get
                    {
                        if (_offset_Reason == -1)
                        {
                            _offset_Reason = 0;
                        }

                        return _offset_Reason;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Reason + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Reason field.
                /// </summary>
                public GCReasonMap Reason => (GCReasonMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Reason..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCTriggeredData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCTriggeredData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Reason = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkRootCCW event.
        /// </summary>
        public readonly ref struct GCBulkRootCCWEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkRootCCW";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 36,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootCCW,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkRootCCWData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkRootCCWEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkRootCCWEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkRootCCW event.
            /// </summary>
            public ref struct GCBulkRootCCWData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkRootCCWValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkRootCCWData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkRootCCWData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkRCW event.
        /// </summary>
        public readonly ref struct GCBulkRCWEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkRCW";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 37,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRCW,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkRCWData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkRCWEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkRCWEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkRCW event.
            /// </summary>
            public ref struct GCBulkRCWData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkRCWValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkRCWData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkRCWData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCBulkRootStaticVar event.
        /// </summary>
        public readonly ref struct GCBulkRootStaticVarEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCBulkRootStaticVar";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 38,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootStaticVar,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCHeapDumpKeyword
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
            public GCBulkRootStaticVarData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCBulkRootStaticVarEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCBulkRootStaticVarEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCBulkRootStaticVar event.
            /// </summary>
            public ref struct GCBulkRootStaticVarData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_AppDomainID;
                private int _offset_ClrInstanceID;
                private int _offset_Values;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_Count + 4;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainID + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCBulkRootStaticVarValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCBulkRootStaticVarData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCBulkRootStaticVarData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_AppDomainID = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCDynamicEvent event.
        /// </summary>
        public readonly ref struct GCDynamicEventEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCDynamicEvent";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 39,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.None,
                Opcode = (EtwEventOpcode)Opcodes.GCDynamicEvent,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword | (ulong)Keywords.GCHandleKeyword | (ulong)Keywords.GCHeapDumpKeyword | (ulong)Keywords.GCSampledObjectAllocationHighKeyword | (ulong)Keywords.GCHeapSurvivalAndMovementKeyword | (ulong)Keywords.GCHeapCollectKeyword | (ulong)Keywords.GCHeapAndTypeNamesKeyword | (ulong)Keywords.GCSampledObjectAllocationLowKeyword
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
            public GCDynamicEventData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCDynamicEventEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCDynamicEventEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCDynamicEvent event.
            /// </summary>
            public ref struct GCDynamicEventData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Name;
                private int _offset_DataSize;
                private int _offset_Data;
                private int _offset_ClrInstanceID;

                private int Offset_Name
                {
                    get
                    {
                        if (_offset_Name == -1)
                        {
                            _offset_Name = 0;
                        }

                        return _offset_Name;
                    }
                }

                private int Offset_DataSize
                {
                    get
                    {
                        if (_offset_DataSize == -1)
                        {
                            _offset_DataSize = Offset_Name + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_Name);
                        }

                        return _offset_DataSize;
                    }
                }

                private int Offset_Data
                {
                    get
                    {
                        if (_offset_Data == -1)
                        {
                            _offset_Data = Offset_DataSize + 4;
                        }

                        return _offset_Data;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Data + (1 * (int)DataSize);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Name field.
                /// </summary>
                public string Name => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_Name..]);

                /// <summary>
                /// Retrieves the DataSize field.
                /// </summary>
                public uint DataSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_DataSize..]);

                /// <summary>
                /// Retrieves the Data field.
                /// </summary>
                public EtwEvent.StructEnumerable<byte> Data => new(_etwEvent, Offset_Data, DataSize);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCDynamicEventData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCDynamicEventData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Name = -1;
                    _offset_DataSize = -1;
                    _offset_Data = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WorkerThreadCreationV2Start event.
        /// </summary>
        public readonly ref struct WorkerThreadCreationV2StartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WorkerThreadCreationV2Start";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 40,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.WorkerThreadCreationV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public WorkerThreadCreationV2StartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WorkerThreadCreationV2StartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WorkerThreadCreationV2StartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WorkerThreadCreationV2Start event.
            /// </summary>
            public ref struct WorkerThreadCreationV2StartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkerThreadCount;
                private int _offset_RetiredWorkerThreads;

                private int Offset_WorkerThreadCount
                {
                    get
                    {
                        if (_offset_WorkerThreadCount == -1)
                        {
                            _offset_WorkerThreadCount = 0;
                        }

                        return _offset_WorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreads
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreads == -1)
                        {
                            _offset_RetiredWorkerThreads = Offset_WorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreads;
                    }
                }

                /// <summary>
                /// Retrieves the WorkerThreadCount field.
                /// </summary>
                public uint WorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreads field.
                /// </summary>
                public uint RetiredWorkerThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreads..]);

                /// <summary>
                /// Creates a new WorkerThreadCreationV2StartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WorkerThreadCreationV2StartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkerThreadCount = -1;
                    _offset_RetiredWorkerThreads = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WorkerThreadCreationV2Stop event.
        /// </summary>
        public readonly ref struct WorkerThreadCreationV2StopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WorkerThreadCreationV2Stop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 41,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.WorkerThreadCreationV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public WorkerThreadCreationV2StopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WorkerThreadCreationV2StopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WorkerThreadCreationV2StopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WorkerThreadCreationV2Stop event.
            /// </summary>
            public ref struct WorkerThreadCreationV2StopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkerThreadCount;
                private int _offset_RetiredWorkerThreads;

                private int Offset_WorkerThreadCount
                {
                    get
                    {
                        if (_offset_WorkerThreadCount == -1)
                        {
                            _offset_WorkerThreadCount = 0;
                        }

                        return _offset_WorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreads
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreads == -1)
                        {
                            _offset_RetiredWorkerThreads = Offset_WorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreads;
                    }
                }

                /// <summary>
                /// Retrieves the WorkerThreadCount field.
                /// </summary>
                public uint WorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreads field.
                /// </summary>
                public uint RetiredWorkerThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreads..]);

                /// <summary>
                /// Creates a new WorkerThreadCreationV2StopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WorkerThreadCreationV2StopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkerThreadCount = -1;
                    _offset_RetiredWorkerThreads = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WorkerThreadRetirementV2Start event.
        /// </summary>
        public readonly ref struct WorkerThreadRetirementV2StartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WorkerThreadRetirementV2Start";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 42,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.WorkerThreadRetirementV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public WorkerThreadRetirementV2StartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WorkerThreadRetirementV2StartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WorkerThreadRetirementV2StartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WorkerThreadRetirementV2Start event.
            /// </summary>
            public ref struct WorkerThreadRetirementV2StartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkerThreadCount;
                private int _offset_RetiredWorkerThreads;

                private int Offset_WorkerThreadCount
                {
                    get
                    {
                        if (_offset_WorkerThreadCount == -1)
                        {
                            _offset_WorkerThreadCount = 0;
                        }

                        return _offset_WorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreads
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreads == -1)
                        {
                            _offset_RetiredWorkerThreads = Offset_WorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreads;
                    }
                }

                /// <summary>
                /// Retrieves the WorkerThreadCount field.
                /// </summary>
                public uint WorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreads field.
                /// </summary>
                public uint RetiredWorkerThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreads..]);

                /// <summary>
                /// Creates a new WorkerThreadRetirementV2StartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WorkerThreadRetirementV2StartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkerThreadCount = -1;
                    _offset_RetiredWorkerThreads = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a WorkerThreadRetirementV2Stop event.
        /// </summary>
        public readonly ref struct WorkerThreadRetirementV2StopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "WorkerThreadRetirementV2Stop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 43,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.WorkerThreadRetirementV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public WorkerThreadRetirementV2StopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new WorkerThreadRetirementV2StopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public WorkerThreadRetirementV2StopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a WorkerThreadRetirementV2Stop event.
            /// </summary>
            public ref struct WorkerThreadRetirementV2StopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkerThreadCount;
                private int _offset_RetiredWorkerThreads;

                private int Offset_WorkerThreadCount
                {
                    get
                    {
                        if (_offset_WorkerThreadCount == -1)
                        {
                            _offset_WorkerThreadCount = 0;
                        }

                        return _offset_WorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreads
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreads == -1)
                        {
                            _offset_RetiredWorkerThreads = Offset_WorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreads;
                    }
                }

                /// <summary>
                /// Retrieves the WorkerThreadCount field.
                /// </summary>
                public uint WorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreads field.
                /// </summary>
                public uint RetiredWorkerThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreads..]);

                /// <summary>
                /// Creates a new WorkerThreadRetirementV2StopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public WorkerThreadRetirementV2StopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkerThreadCount = -1;
                    _offset_RetiredWorkerThreads = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadpoolSuspensionV2Start event.
        /// </summary>
        public readonly ref struct ThreadpoolSuspensionV2StartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadpoolSuspensionV2Start";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 48,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ThreadpoolSuspensionV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadpoolSuspensionV2StartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadpoolSuspensionV2StartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadpoolSuspensionV2StartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadpoolSuspensionV2Start event.
            /// </summary>
            public ref struct ThreadpoolSuspensionV2StartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrThreadID;
                private int _offset_CpuUtilization;

                private int Offset_ClrThreadID
                {
                    get
                    {
                        if (_offset_ClrThreadID == -1)
                        {
                            _offset_ClrThreadID = 0;
                        }

                        return _offset_ClrThreadID;
                    }
                }

                private int Offset_CpuUtilization
                {
                    get
                    {
                        if (_offset_CpuUtilization == -1)
                        {
                            _offset_CpuUtilization = Offset_ClrThreadID + 4;
                        }

                        return _offset_CpuUtilization;
                    }
                }

                /// <summary>
                /// Retrieves the ClrThreadID field.
                /// </summary>
                public uint ClrThreadID => BitConverter.ToUInt32(_etwEvent.Data[Offset_ClrThreadID..]);

                /// <summary>
                /// Retrieves the CpuUtilization field.
                /// </summary>
                public uint CpuUtilization => BitConverter.ToUInt32(_etwEvent.Data[Offset_CpuUtilization..]);

                /// <summary>
                /// Creates a new ThreadpoolSuspensionV2StartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadpoolSuspensionV2StartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrThreadID = -1;
                    _offset_CpuUtilization = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadpoolSuspensionV2Stop event.
        /// </summary>
        public readonly ref struct ThreadpoolSuspensionV2StopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadpoolSuspensionV2Stop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 49,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ThreadpoolSuspensionV2,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadpoolSuspensionV2StopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadpoolSuspensionV2StopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadpoolSuspensionV2StopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadpoolSuspensionV2Stop event.
            /// </summary>
            public ref struct ThreadpoolSuspensionV2StopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrThreadID;
                private int _offset_CpuUtilization;

                private int Offset_ClrThreadID
                {
                    get
                    {
                        if (_offset_ClrThreadID == -1)
                        {
                            _offset_ClrThreadID = 0;
                        }

                        return _offset_ClrThreadID;
                    }
                }

                private int Offset_CpuUtilization
                {
                    get
                    {
                        if (_offset_CpuUtilization == -1)
                        {
                            _offset_CpuUtilization = Offset_ClrThreadID + 4;
                        }

                        return _offset_CpuUtilization;
                    }
                }

                /// <summary>
                /// Retrieves the ClrThreadID field.
                /// </summary>
                public uint ClrThreadID => BitConverter.ToUInt32(_etwEvent.Data[Offset_ClrThreadID..]);

                /// <summary>
                /// Retrieves the CpuUtilization field.
                /// </summary>
                public uint CpuUtilization => BitConverter.ToUInt32(_etwEvent.Data[Offset_CpuUtilization..]);

                /// <summary>
                /// Creates a new ThreadpoolSuspensionV2StopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadpoolSuspensionV2StopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrThreadID = -1;
                    _offset_CpuUtilization = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadStart event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 50,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ThreadPoolWorkerThread,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadStart event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ActiveWorkerThreadCount;
                private int _offset_RetiredWorkerThreadCount;
                private int _offset_ClrInstanceID;

                private int Offset_ActiveWorkerThreadCount
                {
                    get
                    {
                        if (_offset_ActiveWorkerThreadCount == -1)
                        {
                            _offset_ActiveWorkerThreadCount = 0;
                        }

                        return _offset_ActiveWorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreadCount
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreadCount == -1)
                        {
                            _offset_RetiredWorkerThreadCount = Offset_ActiveWorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreadCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredWorkerThreadCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ActiveWorkerThreadCount field.
                /// </summary>
                public uint ActiveWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_ActiveWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreadCount field.
                /// </summary>
                public uint RetiredWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ActiveWorkerThreadCount = -1;
                    _offset_RetiredWorkerThreadCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadStop event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 51,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ThreadPoolWorkerThread,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadStop event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ActiveWorkerThreadCount;
                private int _offset_RetiredWorkerThreadCount;
                private int _offset_ClrInstanceID;

                private int Offset_ActiveWorkerThreadCount
                {
                    get
                    {
                        if (_offset_ActiveWorkerThreadCount == -1)
                        {
                            _offset_ActiveWorkerThreadCount = 0;
                        }

                        return _offset_ActiveWorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreadCount
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreadCount == -1)
                        {
                            _offset_RetiredWorkerThreadCount = Offset_ActiveWorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreadCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredWorkerThreadCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ActiveWorkerThreadCount field.
                /// </summary>
                public uint ActiveWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_ActiveWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreadCount field.
                /// </summary>
                public uint RetiredWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ActiveWorkerThreadCount = -1;
                    _offset_RetiredWorkerThreadCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadRetirementStart event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadRetirementStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadRetirementStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 52,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ThreadPoolWorkerThreadRetirement,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadRetirementStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadRetirementStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadRetirementStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadRetirementStart event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadRetirementStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ActiveWorkerThreadCount;
                private int _offset_RetiredWorkerThreadCount;
                private int _offset_ClrInstanceID;

                private int Offset_ActiveWorkerThreadCount
                {
                    get
                    {
                        if (_offset_ActiveWorkerThreadCount == -1)
                        {
                            _offset_ActiveWorkerThreadCount = 0;
                        }

                        return _offset_ActiveWorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreadCount
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreadCount == -1)
                        {
                            _offset_RetiredWorkerThreadCount = Offset_ActiveWorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreadCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredWorkerThreadCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ActiveWorkerThreadCount field.
                /// </summary>
                public uint ActiveWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_ActiveWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreadCount field.
                /// </summary>
                public uint RetiredWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadRetirementStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadRetirementStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ActiveWorkerThreadCount = -1;
                    _offset_RetiredWorkerThreadCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadRetirementStop event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadRetirementStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadRetirementStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 53,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ThreadPoolWorkerThreadRetirement,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadRetirementStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadRetirementStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadRetirementStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadRetirementStop event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadRetirementStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ActiveWorkerThreadCount;
                private int _offset_RetiredWorkerThreadCount;
                private int _offset_ClrInstanceID;

                private int Offset_ActiveWorkerThreadCount
                {
                    get
                    {
                        if (_offset_ActiveWorkerThreadCount == -1)
                        {
                            _offset_ActiveWorkerThreadCount = 0;
                        }

                        return _offset_ActiveWorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreadCount
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreadCount == -1)
                        {
                            _offset_RetiredWorkerThreadCount = Offset_ActiveWorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreadCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredWorkerThreadCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ActiveWorkerThreadCount field.
                /// </summary>
                public uint ActiveWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_ActiveWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreadCount field.
                /// </summary>
                public uint RetiredWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadRetirementStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadRetirementStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ActiveWorkerThreadCount = -1;
                    _offset_RetiredWorkerThreadCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadAdjustmentSample event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadAdjustmentSampleEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadAdjustmentSample";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 54,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Sample,
                Task = (ushort)Tasks.ThreadPoolWorkerThreadAdjustment,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadAdjustmentSampleData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadAdjustmentSampleEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadAdjustmentSampleEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadAdjustmentSample event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadAdjustmentSampleData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Throughput;
                private int _offset_ClrInstanceID;

                private int Offset_Throughput
                {
                    get
                    {
                        if (_offset_Throughput == -1)
                        {
                            _offset_Throughput = 0;
                        }

                        return _offset_Throughput;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Throughput + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Throughput field.
                /// </summary>
                public double Throughput => BitConverter.ToDouble(_etwEvent.Data[Offset_Throughput..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadAdjustmentSampleData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadAdjustmentSampleData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Throughput = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadAdjustmentAdjustment event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadAdjustmentAdjustmentEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadAdjustmentAdjustment";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 55,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Adjustment,
                Task = (ushort)Tasks.ThreadPoolWorkerThreadAdjustment,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadAdjustmentAdjustmentData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadAdjustmentAdjustmentEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadAdjustmentAdjustmentEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadAdjustmentAdjustment event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadAdjustmentAdjustmentData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AverageThroughput;
                private int _offset_NewWorkerThreadCount;
                private int _offset_Reason;
                private int _offset_ClrInstanceID;

                private int Offset_AverageThroughput
                {
                    get
                    {
                        if (_offset_AverageThroughput == -1)
                        {
                            _offset_AverageThroughput = 0;
                        }

                        return _offset_AverageThroughput;
                    }
                }

                private int Offset_NewWorkerThreadCount
                {
                    get
                    {
                        if (_offset_NewWorkerThreadCount == -1)
                        {
                            _offset_NewWorkerThreadCount = Offset_AverageThroughput + 8;
                        }

                        return _offset_NewWorkerThreadCount;
                    }
                }

                private int Offset_Reason
                {
                    get
                    {
                        if (_offset_Reason == -1)
                        {
                            _offset_Reason = Offset_NewWorkerThreadCount + 4;
                        }

                        return _offset_Reason;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Reason + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AverageThroughput field.
                /// </summary>
                public double AverageThroughput => BitConverter.ToDouble(_etwEvent.Data[Offset_AverageThroughput..]);

                /// <summary>
                /// Retrieves the NewWorkerThreadCount field.
                /// </summary>
                public uint NewWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_NewWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the Reason field.
                /// </summary>
                public ThreadAdjustmentReasonMap Reason => (ThreadAdjustmentReasonMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Reason..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadAdjustmentAdjustmentData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadAdjustmentAdjustmentData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AverageThroughput = -1;
                    _offset_NewWorkerThreadCount = -1;
                    _offset_Reason = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadAdjustmentStats event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadAdjustmentStatsEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadAdjustmentStats";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 56,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.Stats,
                Task = (ushort)Tasks.ThreadPoolWorkerThreadAdjustment,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadAdjustmentStatsData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadAdjustmentStatsEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadAdjustmentStatsEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadAdjustmentStats event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadAdjustmentStatsData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Duration;
                private int _offset_Throughput;
                private int _offset_ThreadWave;
                private int _offset_ThroughputWave;
                private int _offset_ThroughputErrorEstimate;
                private int _offset_AverageThroughputErrorEstimate;
                private int _offset_ThroughputRatio;
                private int _offset_Confidence;
                private int _offset_NewControlSetting;
                private int _offset_NewThreadWaveMagnitude;
                private int _offset_ClrInstanceID;

                private int Offset_Duration
                {
                    get
                    {
                        if (_offset_Duration == -1)
                        {
                            _offset_Duration = 0;
                        }

                        return _offset_Duration;
                    }
                }

                private int Offset_Throughput
                {
                    get
                    {
                        if (_offset_Throughput == -1)
                        {
                            _offset_Throughput = Offset_Duration + 8;
                        }

                        return _offset_Throughput;
                    }
                }

                private int Offset_ThreadWave
                {
                    get
                    {
                        if (_offset_ThreadWave == -1)
                        {
                            _offset_ThreadWave = Offset_Throughput + 8;
                        }

                        return _offset_ThreadWave;
                    }
                }

                private int Offset_ThroughputWave
                {
                    get
                    {
                        if (_offset_ThroughputWave == -1)
                        {
                            _offset_ThroughputWave = Offset_ThreadWave + 8;
                        }

                        return _offset_ThroughputWave;
                    }
                }

                private int Offset_ThroughputErrorEstimate
                {
                    get
                    {
                        if (_offset_ThroughputErrorEstimate == -1)
                        {
                            _offset_ThroughputErrorEstimate = Offset_ThroughputWave + 8;
                        }

                        return _offset_ThroughputErrorEstimate;
                    }
                }

                private int Offset_AverageThroughputErrorEstimate
                {
                    get
                    {
                        if (_offset_AverageThroughputErrorEstimate == -1)
                        {
                            _offset_AverageThroughputErrorEstimate = Offset_ThroughputErrorEstimate + 8;
                        }

                        return _offset_AverageThroughputErrorEstimate;
                    }
                }

                private int Offset_ThroughputRatio
                {
                    get
                    {
                        if (_offset_ThroughputRatio == -1)
                        {
                            _offset_ThroughputRatio = Offset_AverageThroughputErrorEstimate + 8;
                        }

                        return _offset_ThroughputRatio;
                    }
                }

                private int Offset_Confidence
                {
                    get
                    {
                        if (_offset_Confidence == -1)
                        {
                            _offset_Confidence = Offset_ThroughputRatio + 8;
                        }

                        return _offset_Confidence;
                    }
                }

                private int Offset_NewControlSetting
                {
                    get
                    {
                        if (_offset_NewControlSetting == -1)
                        {
                            _offset_NewControlSetting = Offset_Confidence + 8;
                        }

                        return _offset_NewControlSetting;
                    }
                }

                private int Offset_NewThreadWaveMagnitude
                {
                    get
                    {
                        if (_offset_NewThreadWaveMagnitude == -1)
                        {
                            _offset_NewThreadWaveMagnitude = Offset_NewControlSetting + 8;
                        }

                        return _offset_NewThreadWaveMagnitude;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_NewThreadWaveMagnitude + 2;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Duration field.
                /// </summary>
                public double Duration => BitConverter.ToDouble(_etwEvent.Data[Offset_Duration..]);

                /// <summary>
                /// Retrieves the Throughput field.
                /// </summary>
                public double Throughput => BitConverter.ToDouble(_etwEvent.Data[Offset_Throughput..]);

                /// <summary>
                /// Retrieves the ThreadWave field.
                /// </summary>
                public double ThreadWave => BitConverter.ToDouble(_etwEvent.Data[Offset_ThreadWave..]);

                /// <summary>
                /// Retrieves the ThroughputWave field.
                /// </summary>
                public double ThroughputWave => BitConverter.ToDouble(_etwEvent.Data[Offset_ThroughputWave..]);

                /// <summary>
                /// Retrieves the ThroughputErrorEstimate field.
                /// </summary>
                public double ThroughputErrorEstimate => BitConverter.ToDouble(_etwEvent.Data[Offset_ThroughputErrorEstimate..]);

                /// <summary>
                /// Retrieves the AverageThroughputErrorEstimate field.
                /// </summary>
                public double AverageThroughputErrorEstimate => BitConverter.ToDouble(_etwEvent.Data[Offset_AverageThroughputErrorEstimate..]);

                /// <summary>
                /// Retrieves the ThroughputRatio field.
                /// </summary>
                public double ThroughputRatio => BitConverter.ToDouble(_etwEvent.Data[Offset_ThroughputRatio..]);

                /// <summary>
                /// Retrieves the Confidence field.
                /// </summary>
                public double Confidence => BitConverter.ToDouble(_etwEvent.Data[Offset_Confidence..]);

                /// <summary>
                /// Retrieves the NewControlSetting field.
                /// </summary>
                public double NewControlSetting => BitConverter.ToDouble(_etwEvent.Data[Offset_NewControlSetting..]);

                /// <summary>
                /// Retrieves the NewThreadWaveMagnitude field.
                /// </summary>
                public ushort NewThreadWaveMagnitude => BitConverter.ToUInt16(_etwEvent.Data[Offset_NewThreadWaveMagnitude..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadAdjustmentStatsData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadAdjustmentStatsData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Duration = -1;
                    _offset_Throughput = -1;
                    _offset_ThreadWave = -1;
                    _offset_ThroughputWave = -1;
                    _offset_ThroughputErrorEstimate = -1;
                    _offset_AverageThroughputErrorEstimate = -1;
                    _offset_ThroughputRatio = -1;
                    _offset_Confidence = -1;
                    _offset_NewControlSetting = -1;
                    _offset_NewThreadWaveMagnitude = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkerThreadWait event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkerThreadWaitEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkerThreadWait";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 57,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Wait,
                Task = (ushort)Tasks.ThreadPoolWorkerThread,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkerThreadWaitData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkerThreadWaitEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkerThreadWaitEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkerThreadWait event.
            /// </summary>
            public ref struct ThreadPoolWorkerThreadWaitData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ActiveWorkerThreadCount;
                private int _offset_RetiredWorkerThreadCount;
                private int _offset_ClrInstanceID;

                private int Offset_ActiveWorkerThreadCount
                {
                    get
                    {
                        if (_offset_ActiveWorkerThreadCount == -1)
                        {
                            _offset_ActiveWorkerThreadCount = 0;
                        }

                        return _offset_ActiveWorkerThreadCount;
                    }
                }

                private int Offset_RetiredWorkerThreadCount
                {
                    get
                    {
                        if (_offset_RetiredWorkerThreadCount == -1)
                        {
                            _offset_RetiredWorkerThreadCount = Offset_ActiveWorkerThreadCount + 4;
                        }

                        return _offset_RetiredWorkerThreadCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredWorkerThreadCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ActiveWorkerThreadCount field.
                /// </summary>
                public uint ActiveWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_ActiveWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredWorkerThreadCount field.
                /// </summary>
                public uint RetiredWorkerThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredWorkerThreadCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkerThreadWaitData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkerThreadWaitData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ActiveWorkerThreadCount = -1;
                    _offset_RetiredWorkerThreadCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolWorkingThreadCountStart event.
        /// </summary>
        public readonly ref struct ThreadPoolWorkingThreadCountStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolWorkingThreadCountStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 60,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ThreadPoolWorkingThreadCount,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolWorkingThreadCountStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolWorkingThreadCountStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolWorkingThreadCountStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolWorkingThreadCountStart event.
            /// </summary>
            public ref struct ThreadPoolWorkingThreadCountStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_ClrInstanceID;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolWorkingThreadCountStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolWorkingThreadCountStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolEnqueue event.
        /// </summary>
        public readonly ref struct ThreadPoolEnqueueEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolEnqueue";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 61,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.AllocationTick,
                Task = (ushort)Tasks.ThreadPool,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadPoolEnqueueData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolEnqueueEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolEnqueueEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolEnqueue event.
            /// </summary>
            public ref struct ThreadPoolEnqueueData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkID;
                private int _offset_ClrInstanceID;

                private int Offset_WorkID
                {
                    get
                    {
                        if (_offset_WorkID == -1)
                        {
                            _offset_WorkID = 0;
                        }

                        return _offset_WorkID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_WorkID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the WorkID field.
                /// </summary>
                public ulong WorkID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_WorkID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolEnqueueData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolEnqueueData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolDequeue event.
        /// </summary>
        public readonly ref struct ThreadPoolDequeueEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolDequeue";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 62,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.CreateConcurrentThread,
                Task = (ushort)Tasks.ThreadPool,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadPoolDequeueData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolDequeueEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolDequeueEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolDequeue event.
            /// </summary>
            public ref struct ThreadPoolDequeueData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_WorkID;
                private int _offset_ClrInstanceID;

                private int Offset_WorkID
                {
                    get
                    {
                        if (_offset_WorkID == -1)
                        {
                            _offset_WorkID = 0;
                        }

                        return _offset_WorkID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_WorkID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the WorkID field.
                /// </summary>
                public ulong WorkID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_WorkID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_WorkID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolDequeueData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolDequeueData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_WorkID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolIOEnqueue event.
        /// </summary>
        public readonly ref struct ThreadPoolIOEnqueueEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolIOEnqueue";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 63,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.TerminateConcurrentThread,
                Task = (ushort)Tasks.ThreadPool,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadPoolIOEnqueueData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolIOEnqueueEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolIOEnqueueEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolIOEnqueue event.
            /// </summary>
            public ref struct ThreadPoolIOEnqueueData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_NativeOverlapped;
                private int _offset_Overlapped;
                private int _offset_MultiDequeues;
                private int _offset_ClrInstanceID;

                private int Offset_NativeOverlapped
                {
                    get
                    {
                        if (_offset_NativeOverlapped == -1)
                        {
                            _offset_NativeOverlapped = 0;
                        }

                        return _offset_NativeOverlapped;
                    }
                }

                private int Offset_Overlapped
                {
                    get
                    {
                        if (_offset_Overlapped == -1)
                        {
                            _offset_Overlapped = Offset_NativeOverlapped + _etwEvent.AddressSize;
                        }

                        return _offset_Overlapped;
                    }
                }

                private int Offset_MultiDequeues
                {
                    get
                    {
                        if (_offset_MultiDequeues == -1)
                        {
                            _offset_MultiDequeues = Offset_Overlapped + _etwEvent.AddressSize;
                        }

                        return _offset_MultiDequeues;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MultiDequeues + 1;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the NativeOverlapped field.
                /// </summary>
                public ulong NativeOverlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NativeOverlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NativeOverlapped..]);

                /// <summary>
                /// Retrieves the Overlapped field.
                /// </summary>
                public ulong Overlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Overlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Overlapped..]);

                /// <summary>
                /// Retrieves the MultiDequeues field.
                /// </summary>
                public bool MultiDequeues => _etwEvent.Data[Offset_MultiDequeues] != 0;

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolIOEnqueueData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolIOEnqueueData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_NativeOverlapped = -1;
                    _offset_Overlapped = -1;
                    _offset_MultiDequeues = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolIODequeue event.
        /// </summary>
        public readonly ref struct ThreadPoolIODequeueEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolIODequeue";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 64,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.IODequeue,
                Task = (ushort)Tasks.ThreadPool,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadPoolIODequeueData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolIODequeueEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolIODequeueEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolIODequeue event.
            /// </summary>
            public ref struct ThreadPoolIODequeueData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_NativeOverlapped;
                private int _offset_Overlapped;
                private int _offset_ClrInstanceID;

                private int Offset_NativeOverlapped
                {
                    get
                    {
                        if (_offset_NativeOverlapped == -1)
                        {
                            _offset_NativeOverlapped = 0;
                        }

                        return _offset_NativeOverlapped;
                    }
                }

                private int Offset_Overlapped
                {
                    get
                    {
                        if (_offset_Overlapped == -1)
                        {
                            _offset_Overlapped = Offset_NativeOverlapped + _etwEvent.AddressSize;
                        }

                        return _offset_Overlapped;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Overlapped + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the NativeOverlapped field.
                /// </summary>
                public ulong NativeOverlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NativeOverlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NativeOverlapped..]);

                /// <summary>
                /// Retrieves the Overlapped field.
                /// </summary>
                public ulong Overlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Overlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Overlapped..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolIODequeueData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolIODequeueData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_NativeOverlapped = -1;
                    _offset_Overlapped = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadPoolIOPack event.
        /// </summary>
        public readonly ref struct ThreadPoolIOPackEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadPoolIOPack";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 65,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.FinalizersStop,
                Task = (ushort)Tasks.ThreadPool,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public ThreadPoolIOPackData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadPoolIOPackEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadPoolIOPackEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadPoolIOPack event.
            /// </summary>
            public ref struct ThreadPoolIOPackData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_NativeOverlapped;
                private int _offset_Overlapped;
                private int _offset_ClrInstanceID;

                private int Offset_NativeOverlapped
                {
                    get
                    {
                        if (_offset_NativeOverlapped == -1)
                        {
                            _offset_NativeOverlapped = 0;
                        }

                        return _offset_NativeOverlapped;
                    }
                }

                private int Offset_Overlapped
                {
                    get
                    {
                        if (_offset_Overlapped == -1)
                        {
                            _offset_Overlapped = Offset_NativeOverlapped + _etwEvent.AddressSize;
                        }

                        return _offset_Overlapped;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Overlapped + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the NativeOverlapped field.
                /// </summary>
                public ulong NativeOverlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NativeOverlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NativeOverlapped..]);

                /// <summary>
                /// Retrieves the Overlapped field.
                /// </summary>
                public ulong Overlapped => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Overlapped..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Overlapped..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadPoolIOPackData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadPoolIOPackData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_NativeOverlapped = -1;
                    _offset_Overlapped = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadCreating event.
        /// </summary>
        public readonly ref struct ThreadCreatingEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadCreating";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 70,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.AllocationTick,
                Task = (ushort)Tasks.Thread,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadCreatingData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadCreatingEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadCreatingEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadCreating event.
            /// </summary>
            public ref struct ThreadCreatingData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ID;
                private int _offset_ClrInstanceID;

                private int Offset_ID
                {
                    get
                    {
                        if (_offset_ID == -1)
                        {
                            _offset_ID = 0;
                        }

                        return _offset_ID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ID field.
                /// </summary>
                public ulong ID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadCreatingData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadCreatingData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ThreadRunning event.
        /// </summary>
        public readonly ref struct ThreadRunningEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ThreadRunning";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 71,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.CreateConcurrentThread,
                Task = (ushort)Tasks.Thread,
                Keyword = (ulong)Keywords.ThreadingKeyword | (ulong)Keywords.ThreadTransferKeyword
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
            public ThreadRunningData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ThreadRunningEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ThreadRunningEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ThreadRunning event.
            /// </summary>
            public ref struct ThreadRunningData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ID;
                private int _offset_ClrInstanceID;

                private int Offset_ID
                {
                    get
                    {
                        if (_offset_ID == -1)
                        {
                            _offset_ID = 0;
                        }

                        return _offset_ID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ID + _etwEvent.AddressSize;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ID field.
                /// </summary>
                public ulong ID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ThreadRunningData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ThreadRunningData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ClrStackWalk event.
        /// </summary>
        public readonly ref struct ClrStackWalkEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ClrStackWalk";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 82,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.None,
                Opcode = (EtwEventOpcode)Opcodes.Walk,
                Task = (ushort)Tasks.ClrStack,
                Keyword = (ulong)Keywords.StackKeyword
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
            public ClrStackWalkData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ClrStackWalkEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ClrStackWalkEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ClrStackWalk event.
            /// </summary>
            public ref struct ClrStackWalkData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_Reserved1;
                private int _offset_Reserved2;
                private int _offset_FrameCount;
                private int _offset_Stack;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_Reserved2
                {
                    get
                    {
                        if (_offset_Reserved2 == -1)
                        {
                            _offset_Reserved2 = Offset_Reserved1 + 1;
                        }

                        return _offset_Reserved2;
                    }
                }

                private int Offset_FrameCount
                {
                    get
                    {
                        if (_offset_FrameCount == -1)
                        {
                            _offset_FrameCount = Offset_Reserved2 + 1;
                        }

                        return _offset_FrameCount;
                    }
                }

                private int Offset_Stack
                {
                    get
                    {
                        if (_offset_Stack == -1)
                        {
                            _offset_Stack = Offset_FrameCount + 4;
                        }

                        return _offset_Stack;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public byte Reserved1 => _etwEvent.Data[Offset_Reserved1];

                /// <summary>
                /// Retrieves the Reserved2 field.
                /// </summary>
                public byte Reserved2 => _etwEvent.Data[Offset_Reserved2];

                /// <summary>
                /// Retrieves the FrameCount field.
                /// </summary>
                public uint FrameCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_FrameCount..]);

                /// <summary>
                /// Retrieves the Stack field.
                /// </summary>
                public ulong Stack => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Stack..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Stack..]);

                /// <summary>
                /// Creates a new ClrStackWalkData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ClrStackWalkData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_Reserved1 = -1;
                    _offset_Reserved2 = -1;
                    _offset_FrameCount = -1;
                    _offset_Stack = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AppDomainResourceManagementMemAllocated event.
        /// </summary>
        public readonly ref struct AppDomainResourceManagementMemAllocatedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AppDomainResourceManagementMemAllocated";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 83,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MemAllocated,
                Task = (ushort)Tasks.AppDomainResourceManagement,
                Keyword = (ulong)Keywords.AppDomainResourceManagementKeyword
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
            public AppDomainResourceManagementMemAllocatedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AppDomainResourceManagementMemAllocatedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AppDomainResourceManagementMemAllocatedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AppDomainResourceManagementMemAllocated event.
            /// </summary>
            public ref struct AppDomainResourceManagementMemAllocatedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AppDomainID;
                private int _offset_Allocated;
                private int _offset_ClrInstanceID;

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = 0;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_Allocated
                {
                    get
                    {
                        if (_offset_Allocated == -1)
                        {
                            _offset_Allocated = Offset_AppDomainID + 8;
                        }

                        return _offset_Allocated;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Allocated + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the Allocated field.
                /// </summary>
                public ulong Allocated => BitConverter.ToUInt64(_etwEvent.Data[Offset_Allocated..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AppDomainResourceManagementMemAllocatedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AppDomainResourceManagementMemAllocatedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AppDomainID = -1;
                    _offset_Allocated = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AppDomainResourceManagementMemSurvived event.
        /// </summary>
        public readonly ref struct AppDomainResourceManagementMemSurvivedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AppDomainResourceManagementMemSurvived";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 84,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.MemSurvived,
                Task = (ushort)Tasks.AppDomainResourceManagement,
                Keyword = (ulong)Keywords.AppDomainResourceManagementKeyword
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
            public AppDomainResourceManagementMemSurvivedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AppDomainResourceManagementMemSurvivedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AppDomainResourceManagementMemSurvivedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AppDomainResourceManagementMemSurvived event.
            /// </summary>
            public ref struct AppDomainResourceManagementMemSurvivedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AppDomainID;
                private int _offset_Survived;
                private int _offset_ProcessSurvived;
                private int _offset_ClrInstanceID;

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = 0;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_Survived
                {
                    get
                    {
                        if (_offset_Survived == -1)
                        {
                            _offset_Survived = Offset_AppDomainID + 8;
                        }

                        return _offset_Survived;
                    }
                }

                private int Offset_ProcessSurvived
                {
                    get
                    {
                        if (_offset_ProcessSurvived == -1)
                        {
                            _offset_ProcessSurvived = Offset_Survived + 8;
                        }

                        return _offset_ProcessSurvived;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ProcessSurvived + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the Survived field.
                /// </summary>
                public ulong Survived => BitConverter.ToUInt64(_etwEvent.Data[Offset_Survived..]);

                /// <summary>
                /// Retrieves the ProcessSurvived field.
                /// </summary>
                public ulong ProcessSurvived => BitConverter.ToUInt64(_etwEvent.Data[Offset_ProcessSurvived..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AppDomainResourceManagementMemSurvivedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AppDomainResourceManagementMemSurvivedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AppDomainID = -1;
                    _offset_Survived = -1;
                    _offset_ProcessSurvived = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AppDomainResourceManagementThreadCreated event.
        /// </summary>
        public readonly ref struct AppDomainResourceManagementThreadCreatedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AppDomainResourceManagementThreadCreated";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 85,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.ThreadCreated,
                Task = (ushort)Tasks.AppDomainResourceManagement,
                Keyword = (ulong)Keywords.AppDomainResourceManagementKeyword | (ulong)Keywords.ThreadingKeyword
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
            public AppDomainResourceManagementThreadCreatedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AppDomainResourceManagementThreadCreatedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AppDomainResourceManagementThreadCreatedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AppDomainResourceManagementThreadCreated event.
            /// </summary>
            public ref struct AppDomainResourceManagementThreadCreatedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ManagedThreadID;
                private int _offset_AppDomainID;
                private int _offset_Flags;
                private int _offset_ManagedThreadIndex;
                private int _offset_OSThreadID;
                private int _offset_ClrInstanceID;

                private int Offset_ManagedThreadID
                {
                    get
                    {
                        if (_offset_ManagedThreadID == -1)
                        {
                            _offset_ManagedThreadID = 0;
                        }

                        return _offset_ManagedThreadID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_ManagedThreadID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_Flags
                {
                    get
                    {
                        if (_offset_Flags == -1)
                        {
                            _offset_Flags = Offset_AppDomainID + 8;
                        }

                        return _offset_Flags;
                    }
                }

                private int Offset_ManagedThreadIndex
                {
                    get
                    {
                        if (_offset_ManagedThreadIndex == -1)
                        {
                            _offset_ManagedThreadIndex = Offset_Flags + 4;
                        }

                        return _offset_ManagedThreadIndex;
                    }
                }

                private int Offset_OSThreadID
                {
                    get
                    {
                        if (_offset_OSThreadID == -1)
                        {
                            _offset_OSThreadID = Offset_ManagedThreadIndex + 4;
                        }

                        return _offset_OSThreadID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_OSThreadID + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ManagedThreadID field.
                /// </summary>
                public ulong ManagedThreadID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ManagedThreadID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the Flags field.
                /// </summary>
                public ThreadFlagsMap Flags => (ThreadFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Flags..]);

                /// <summary>
                /// Retrieves the ManagedThreadIndex field.
                /// </summary>
                public uint ManagedThreadIndex => BitConverter.ToUInt32(_etwEvent.Data[Offset_ManagedThreadIndex..]);

                /// <summary>
                /// Retrieves the OSThreadID field.
                /// </summary>
                public uint OSThreadID => BitConverter.ToUInt32(_etwEvent.Data[Offset_OSThreadID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AppDomainResourceManagementThreadCreatedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AppDomainResourceManagementThreadCreatedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ManagedThreadID = -1;
                    _offset_AppDomainID = -1;
                    _offset_Flags = -1;
                    _offset_ManagedThreadIndex = -1;
                    _offset_OSThreadID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AppDomainResourceManagementThreadTerminated event.
        /// </summary>
        public readonly ref struct AppDomainResourceManagementThreadTerminatedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AppDomainResourceManagementThreadTerminated";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 86,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.ThreadTerminated,
                Task = (ushort)Tasks.AppDomainResourceManagement,
                Keyword = (ulong)Keywords.AppDomainResourceManagementKeyword | (ulong)Keywords.ThreadingKeyword
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
            public AppDomainResourceManagementThreadTerminatedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AppDomainResourceManagementThreadTerminatedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AppDomainResourceManagementThreadTerminatedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AppDomainResourceManagementThreadTerminated event.
            /// </summary>
            public ref struct AppDomainResourceManagementThreadTerminatedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ManagedThreadID;
                private int _offset_AppDomainID;
                private int _offset_ClrInstanceID;

                private int Offset_ManagedThreadID
                {
                    get
                    {
                        if (_offset_ManagedThreadID == -1)
                        {
                            _offset_ManagedThreadID = 0;
                        }

                        return _offset_ManagedThreadID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_ManagedThreadID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainID + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ManagedThreadID field.
                /// </summary>
                public ulong ManagedThreadID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ManagedThreadID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AppDomainResourceManagementThreadTerminatedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AppDomainResourceManagementThreadTerminatedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ManagedThreadID = -1;
                    _offset_AppDomainID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AppDomainResourceManagementDomainEnter event.
        /// </summary>
        public readonly ref struct AppDomainResourceManagementDomainEnterEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AppDomainResourceManagementDomainEnter";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 87,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.DomainEnter,
                Task = (ushort)Tasks.AppDomainResourceManagement,
                Keyword = (ulong)Keywords.AppDomainResourceManagementKeyword | (ulong)Keywords.ThreadingKeyword
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
            public AppDomainResourceManagementDomainEnterData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AppDomainResourceManagementDomainEnterEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AppDomainResourceManagementDomainEnterEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AppDomainResourceManagementDomainEnter event.
            /// </summary>
            public ref struct AppDomainResourceManagementDomainEnterData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ManagedThreadID;
                private int _offset_AppDomainID;
                private int _offset_ClrInstanceID;

                private int Offset_ManagedThreadID
                {
                    get
                    {
                        if (_offset_ManagedThreadID == -1)
                        {
                            _offset_ManagedThreadID = 0;
                        }

                        return _offset_ManagedThreadID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_ManagedThreadID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainID + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ManagedThreadID field.
                /// </summary>
                public ulong ManagedThreadID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ManagedThreadID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AppDomainResourceManagementDomainEnterData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AppDomainResourceManagementDomainEnterData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ManagedThreadID = -1;
                    _offset_AppDomainID = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ILStubStubGenerated event.
        /// </summary>
        public readonly ref struct ILStubStubGeneratedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ILStubStubGenerated";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 88,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.StubGenerated,
                Task = (ushort)Tasks.ILStub,
                Keyword = (ulong)Keywords.InteropKeyword
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
            public ILStubStubGeneratedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ILStubStubGeneratedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ILStubStubGeneratedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ILStubStubGenerated event.
            /// </summary>
            public ref struct ILStubStubGeneratedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_ModuleID;
                private int _offset_StubMethodID;
                private int _offset_StubFlags;
                private int _offset_ManagedInteropMethodToken;
                private int _offset_ManagedInteropMethodNamespace;
                private int _offset_ManagedInteropMethodName;
                private int _offset_ManagedInteropMethodSignature;
                private int _offset_NativeMethodSignature;
                private int _offset_StubMethodSignature;
                private int _offset_StubMethodILCode;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_StubMethodID
                {
                    get
                    {
                        if (_offset_StubMethodID == -1)
                        {
                            _offset_StubMethodID = Offset_ModuleID + 8;
                        }

                        return _offset_StubMethodID;
                    }
                }

                private int Offset_StubFlags
                {
                    get
                    {
                        if (_offset_StubFlags == -1)
                        {
                            _offset_StubFlags = Offset_StubMethodID + 8;
                        }

                        return _offset_StubFlags;
                    }
                }

                private int Offset_ManagedInteropMethodToken
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodToken == -1)
                        {
                            _offset_ManagedInteropMethodToken = Offset_StubFlags + 4;
                        }

                        return _offset_ManagedInteropMethodToken;
                    }
                }

                private int Offset_ManagedInteropMethodNamespace
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodNamespace == -1)
                        {
                            _offset_ManagedInteropMethodNamespace = Offset_ManagedInteropMethodToken + 4;
                        }

                        return _offset_ManagedInteropMethodNamespace;
                    }
                }

                private int Offset_ManagedInteropMethodName
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodName == -1)
                        {
                            _offset_ManagedInteropMethodName = Offset_ManagedInteropMethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedInteropMethodNamespace);
                        }

                        return _offset_ManagedInteropMethodName;
                    }
                }

                private int Offset_ManagedInteropMethodSignature
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodSignature == -1)
                        {
                            _offset_ManagedInteropMethodSignature = Offset_ManagedInteropMethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedInteropMethodName);
                        }

                        return _offset_ManagedInteropMethodSignature;
                    }
                }

                private int Offset_NativeMethodSignature
                {
                    get
                    {
                        if (_offset_NativeMethodSignature == -1)
                        {
                            _offset_NativeMethodSignature = Offset_ManagedInteropMethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedInteropMethodSignature);
                        }

                        return _offset_NativeMethodSignature;
                    }
                }

                private int Offset_StubMethodSignature
                {
                    get
                    {
                        if (_offset_StubMethodSignature == -1)
                        {
                            _offset_StubMethodSignature = Offset_NativeMethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_NativeMethodSignature);
                        }

                        return _offset_StubMethodSignature;
                    }
                }

                private int Offset_StubMethodILCode
                {
                    get
                    {
                        if (_offset_StubMethodILCode == -1)
                        {
                            _offset_StubMethodILCode = Offset_StubMethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_StubMethodSignature);
                        }

                        return _offset_StubMethodILCode;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the StubMethodID field.
                /// </summary>
                public ulong StubMethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_StubMethodID..]);

                /// <summary>
                /// Retrieves the StubFlags field.
                /// </summary>
                public ILStubGeneratedFlagsMap StubFlags => (ILStubGeneratedFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_StubFlags..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodToken field.
                /// </summary>
                public uint ManagedInteropMethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_ManagedInteropMethodToken..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodNamespace field.
                /// </summary>
                public string ManagedInteropMethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodNamespace..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodName field.
                /// </summary>
                public string ManagedInteropMethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodName..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodSignature field.
                /// </summary>
                public string ManagedInteropMethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodSignature..]);

                /// <summary>
                /// Retrieves the NativeMethodSignature field.
                /// </summary>
                public string NativeMethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_NativeMethodSignature..]);

                /// <summary>
                /// Retrieves the StubMethodSignature field.
                /// </summary>
                public string StubMethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_StubMethodSignature..]);

                /// <summary>
                /// Retrieves the StubMethodILCode field.
                /// </summary>
                public string StubMethodILCode => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_StubMethodILCode..]);

                /// <summary>
                /// Creates a new ILStubStubGeneratedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ILStubStubGeneratedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_ModuleID = -1;
                    _offset_StubMethodID = -1;
                    _offset_StubFlags = -1;
                    _offset_ManagedInteropMethodToken = -1;
                    _offset_ManagedInteropMethodNamespace = -1;
                    _offset_ManagedInteropMethodName = -1;
                    _offset_ManagedInteropMethodSignature = -1;
                    _offset_NativeMethodSignature = -1;
                    _offset_StubMethodSignature = -1;
                    _offset_StubMethodILCode = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ILStubStubCacheHit event.
        /// </summary>
        public readonly ref struct ILStubStubCacheHitEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ILStubStubCacheHit";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 89,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.StubCacheHit,
                Task = (ushort)Tasks.ILStub,
                Keyword = (ulong)Keywords.InteropKeyword
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
            public ILStubStubCacheHitData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ILStubStubCacheHitEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ILStubStubCacheHitEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ILStubStubCacheHit event.
            /// </summary>
            public ref struct ILStubStubCacheHitData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_ModuleID;
                private int _offset_StubMethodID;
                private int _offset_ManagedInteropMethodToken;
                private int _offset_ManagedInteropMethodNamespace;
                private int _offset_ManagedInteropMethodName;
                private int _offset_ManagedInteropMethodSignature;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_StubMethodID
                {
                    get
                    {
                        if (_offset_StubMethodID == -1)
                        {
                            _offset_StubMethodID = Offset_ModuleID + 8;
                        }

                        return _offset_StubMethodID;
                    }
                }

                private int Offset_ManagedInteropMethodToken
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodToken == -1)
                        {
                            _offset_ManagedInteropMethodToken = Offset_StubMethodID + 8;
                        }

                        return _offset_ManagedInteropMethodToken;
                    }
                }

                private int Offset_ManagedInteropMethodNamespace
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodNamespace == -1)
                        {
                            _offset_ManagedInteropMethodNamespace = Offset_ManagedInteropMethodToken + 4;
                        }

                        return _offset_ManagedInteropMethodNamespace;
                    }
                }

                private int Offset_ManagedInteropMethodName
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodName == -1)
                        {
                            _offset_ManagedInteropMethodName = Offset_ManagedInteropMethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedInteropMethodNamespace);
                        }

                        return _offset_ManagedInteropMethodName;
                    }
                }

                private int Offset_ManagedInteropMethodSignature
                {
                    get
                    {
                        if (_offset_ManagedInteropMethodSignature == -1)
                        {
                            _offset_ManagedInteropMethodSignature = Offset_ManagedInteropMethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedInteropMethodName);
                        }

                        return _offset_ManagedInteropMethodSignature;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the StubMethodID field.
                /// </summary>
                public ulong StubMethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_StubMethodID..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodToken field.
                /// </summary>
                public uint ManagedInteropMethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_ManagedInteropMethodToken..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodNamespace field.
                /// </summary>
                public string ManagedInteropMethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodNamespace..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodName field.
                /// </summary>
                public string ManagedInteropMethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodName..]);

                /// <summary>
                /// Retrieves the ManagedInteropMethodSignature field.
                /// </summary>
                public string ManagedInteropMethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedInteropMethodSignature..]);

                /// <summary>
                /// Creates a new ILStubStubCacheHitData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ILStubStubCacheHitData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_ModuleID = -1;
                    _offset_StubMethodID = -1;
                    _offset_ManagedInteropMethodToken = -1;
                    _offset_ManagedInteropMethodNamespace = -1;
                    _offset_ManagedInteropMethodName = -1;
                    _offset_ManagedInteropMethodSignature = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ContentionStop event.
        /// </summary>
        public readonly ref struct ContentionStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ContentionStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 91,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.Contention,
                Keyword = (ulong)Keywords.ContentionKeyword
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
            public ContentionStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ContentionStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ContentionStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ContentionStop event.
            /// </summary>
            public ref struct ContentionStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ContentionFlags;
                private int _offset_ClrInstanceID;

                private int Offset_ContentionFlags
                {
                    get
                    {
                        if (_offset_ContentionFlags == -1)
                        {
                            _offset_ContentionFlags = 0;
                        }

                        return _offset_ContentionFlags;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ContentionFlags + 1;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ContentionFlags field.
                /// </summary>
                public ContentionFlagsMap ContentionFlags => (ContentionFlagsMap)_etwEvent.Data[Offset_ContentionFlags];

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ContentionStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ContentionStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ContentionFlags = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodDCStartCompleteV2 event.
        /// </summary>
        public readonly ref struct MethodDCStartCompleteV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCStartCompleteV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 135,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.IODequeue,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            /// Creates a new MethodDCStartCompleteV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCStartCompleteV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a MethodDCEndCompleteV2 event.
        /// </summary>
        public readonly ref struct MethodDCEndCompleteV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCEndCompleteV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 136,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.FinalizersStop,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            /// Creates a new MethodDCEndCompleteV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCEndCompleteV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a MethodDCStartV2 event.
        /// </summary>
        public readonly ref struct MethodDCStartV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCStartV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 137,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Triggered,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodDCStartV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodDCStartV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCStartV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodDCStartV2 event.
            /// </summary>
            public ref struct MethodDCStartV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Creates a new MethodDCStartV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodDCStartV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodDCStopV2 event.
        /// </summary>
        public readonly ref struct MethodDCStopV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCStopV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 138,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.PinObjectAtGCTime,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodDCStopV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodDCStopV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCStopV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodDCStopV2 event.
            /// </summary>
            public ref struct MethodDCStopV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Creates a new MethodDCStopV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodDCStopV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodDCStartVerboseV2 event.
        /// </summary>
        public readonly ref struct MethodDCStartVerboseV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCStartVerboseV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 139,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRCW,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodDCStartVerboseV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodDCStartVerboseV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCStartVerboseV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodDCStartVerboseV2 event.
            /// </summary>
            public ref struct MethodDCStartVerboseV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_MethodNamespace;
                private int _offset_MethodName;
                private int _offset_MethodSignature;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_MethodNamespace
                {
                    get
                    {
                        if (_offset_MethodNamespace == -1)
                        {
                            _offset_MethodNamespace = Offset_MethodFlags + 4;
                        }

                        return _offset_MethodNamespace;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodNamespace);
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_MethodSignature
                {
                    get
                    {
                        if (_offset_MethodSignature == -1)
                        {
                            _offset_MethodSignature = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_MethodSignature;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the MethodNamespace field.
                /// </summary>
                public string MethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodNamespace..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the MethodSignature field.
                /// </summary>
                public string MethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodSignature..]);

                /// <summary>
                /// Creates a new MethodDCStartVerboseV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodDCStartVerboseV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_MethodNamespace = -1;
                    _offset_MethodName = -1;
                    _offset_MethodSignature = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodDCStopVerboseV2 event.
        /// </summary>
        public readonly ref struct MethodDCStopVerboseV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodDCStopVerboseV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 140,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootStaticVar,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodDCStopVerboseV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodDCStopVerboseV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodDCStopVerboseV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodDCStopVerboseV2 event.
            /// </summary>
            public ref struct MethodDCStopVerboseV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_MethodNamespace;
                private int _offset_MethodName;
                private int _offset_MethodSignature;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_MethodNamespace
                {
                    get
                    {
                        if (_offset_MethodNamespace == -1)
                        {
                            _offset_MethodNamespace = Offset_MethodFlags + 4;
                        }

                        return _offset_MethodNamespace;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodNamespace);
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_MethodSignature
                {
                    get
                    {
                        if (_offset_MethodSignature == -1)
                        {
                            _offset_MethodSignature = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_MethodSignature;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the MethodNamespace field.
                /// </summary>
                public string MethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodNamespace..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the MethodSignature field.
                /// </summary>
                public string MethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodSignature..]);

                /// <summary>
                /// Creates a new MethodDCStopVerboseV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodDCStopVerboseV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_MethodNamespace = -1;
                    _offset_MethodName = -1;
                    _offset_MethodSignature = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderModuleDCStartV2 event.
        /// </summary>
        public readonly ref struct LoaderModuleDCStartV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderModuleDCStartV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 149,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Triggered,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderModuleDCStartV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderModuleDCStartV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderModuleDCStartV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderModuleDCStartV2 event.
            /// </summary>
            public ref struct LoaderModuleDCStartV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ModuleID;
                private int _offset_AssemblyID;
                private int _offset_ModuleFlags;
                private int _offset_Reserved1;
                private int _offset_ModuleILPath;
                private int _offset_ModuleNativePath;

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = 0;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = Offset_ModuleID + 8;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_ModuleFlags
                {
                    get
                    {
                        if (_offset_ModuleFlags == -1)
                        {
                            _offset_ModuleFlags = Offset_AssemblyID + 8;
                        }

                        return _offset_ModuleFlags;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ModuleFlags + 4;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_ModuleILPath
                {
                    get
                    {
                        if (_offset_ModuleILPath == -1)
                        {
                            _offset_ModuleILPath = Offset_Reserved1 + 4;
                        }

                        return _offset_ModuleILPath;
                    }
                }

                private int Offset_ModuleNativePath
                {
                    get
                    {
                        if (_offset_ModuleNativePath == -1)
                        {
                            _offset_ModuleNativePath = Offset_ModuleILPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleILPath);
                        }

                        return _offset_ModuleNativePath;
                    }
                }

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the ModuleFlags field.
                /// </summary>
                public ModuleFlagsMap ModuleFlags => (ModuleFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_ModuleFlags..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public uint Reserved1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reserved1..]);

                /// <summary>
                /// Retrieves the ModuleILPath field.
                /// </summary>
                public string ModuleILPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleILPath..]);

                /// <summary>
                /// Retrieves the ModuleNativePath field.
                /// </summary>
                public string ModuleNativePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleNativePath..]);

                /// <summary>
                /// Creates a new LoaderModuleDCStartV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderModuleDCStartV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ModuleID = -1;
                    _offset_AssemblyID = -1;
                    _offset_ModuleFlags = -1;
                    _offset_Reserved1 = -1;
                    _offset_ModuleILPath = -1;
                    _offset_ModuleNativePath = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderModuleDCStopV2 event.
        /// </summary>
        public readonly ref struct LoaderModuleDCStopV2Event
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderModuleDCStopV2";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 150,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.PinObjectAtGCTime,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderModuleDCStopV2Data Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderModuleDCStopV2Event.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderModuleDCStopV2Event(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderModuleDCStopV2 event.
            /// </summary>
            public ref struct LoaderModuleDCStopV2Data
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ModuleID;
                private int _offset_AssemblyID;
                private int _offset_ModuleFlags;
                private int _offset_Reserved1;
                private int _offset_ModuleILPath;
                private int _offset_ModuleNativePath;

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = 0;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = Offset_ModuleID + 8;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_ModuleFlags
                {
                    get
                    {
                        if (_offset_ModuleFlags == -1)
                        {
                            _offset_ModuleFlags = Offset_AssemblyID + 8;
                        }

                        return _offset_ModuleFlags;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ModuleFlags + 4;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_ModuleILPath
                {
                    get
                    {
                        if (_offset_ModuleILPath == -1)
                        {
                            _offset_ModuleILPath = Offset_Reserved1 + 4;
                        }

                        return _offset_ModuleILPath;
                    }
                }

                private int Offset_ModuleNativePath
                {
                    get
                    {
                        if (_offset_ModuleNativePath == -1)
                        {
                            _offset_ModuleNativePath = Offset_ModuleILPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleILPath);
                        }

                        return _offset_ModuleNativePath;
                    }
                }

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the ModuleFlags field.
                /// </summary>
                public ModuleFlagsMap ModuleFlags => (ModuleFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_ModuleFlags..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public uint Reserved1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reserved1..]);

                /// <summary>
                /// Retrieves the ModuleILPath field.
                /// </summary>
                public string ModuleILPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleILPath..]);

                /// <summary>
                /// Retrieves the ModuleNativePath field.
                /// </summary>
                public string ModuleNativePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleNativePath..]);

                /// <summary>
                /// Creates a new LoaderModuleDCStopV2Data.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderModuleDCStopV2Data(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ModuleID = -1;
                    _offset_AssemblyID = -1;
                    _offset_ModuleFlags = -1;
                    _offset_Reserved1 = -1;
                    _offset_ModuleILPath = -1;
                    _offset_ModuleNativePath = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ClrPerfTrackModuleRangeLoad event.
        /// </summary>
        public readonly ref struct ClrPerfTrackModuleRangeLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ClrPerfTrackModuleRangeLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 158,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SuspendEEStart,
                Task = (ushort)Tasks.ClrPerfTrack,
                Keyword = (ulong)Keywords.PerfTrackKeyword
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
            public ClrPerfTrackModuleRangeLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ClrPerfTrackModuleRangeLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ClrPerfTrackModuleRangeLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ClrPerfTrackModuleRangeLoad event.
            /// </summary>
            public ref struct ClrPerfTrackModuleRangeLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_ModuleID;
                private int _offset_RangeBegin;
                private int _offset_RangeSize;
                private int _offset_RangeType;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_RangeBegin
                {
                    get
                    {
                        if (_offset_RangeBegin == -1)
                        {
                            _offset_RangeBegin = Offset_ModuleID + 8;
                        }

                        return _offset_RangeBegin;
                    }
                }

                private int Offset_RangeSize
                {
                    get
                    {
                        if (_offset_RangeSize == -1)
                        {
                            _offset_RangeSize = Offset_RangeBegin + 4;
                        }

                        return _offset_RangeSize;
                    }
                }

                private int Offset_RangeType
                {
                    get
                    {
                        if (_offset_RangeType == -1)
                        {
                            _offset_RangeType = Offset_RangeSize + 4;
                        }

                        return _offset_RangeType;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the RangeBegin field.
                /// </summary>
                public uint RangeBegin => BitConverter.ToUInt32(_etwEvent.Data[Offset_RangeBegin..]);

                /// <summary>
                /// Retrieves the RangeSize field.
                /// </summary>
                public uint RangeSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_RangeSize..]);

                /// <summary>
                /// Retrieves the RangeType field.
                /// </summary>
                public ModuleRangeTypeMap RangeType => (ModuleRangeTypeMap)_etwEvent.Data[Offset_RangeType];

                /// <summary>
                /// Creates a new ClrPerfTrackModuleRangeLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ClrPerfTrackModuleRangeLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_ModuleID = -1;
                    _offset_RangeBegin = -1;
                    _offset_RangeSize = -1;
                    _offset_RangeType = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodInliningSucceeded event.
        /// </summary>
        public readonly ref struct MethodInliningSucceededEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodInliningSucceeded";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 185,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.InliningSucceeded,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitTracingKeyword
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
            public MethodInliningSucceededData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodInliningSucceededEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodInliningSucceededEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodInliningSucceeded event.
            /// </summary>
            public ref struct MethodInliningSucceededData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodBeingCompiledNamespace;
                private int _offset_MethodBeingCompiledName;
                private int _offset_MethodBeingCompiledNameSignature;
                private int _offset_InlinerNamespace;
                private int _offset_InlinerName;
                private int _offset_InlinerNameSignature;
                private int _offset_InlineeNamespace;
                private int _offset_InlineeName;
                private int _offset_InlineeNameSignature;
                private int _offset_ClrInstanceID;

                private int Offset_MethodBeingCompiledNamespace
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNamespace == -1)
                        {
                            _offset_MethodBeingCompiledNamespace = 0;
                        }

                        return _offset_MethodBeingCompiledNamespace;
                    }
                }

                private int Offset_MethodBeingCompiledName
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledName == -1)
                        {
                            _offset_MethodBeingCompiledName = Offset_MethodBeingCompiledNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNamespace);
                        }

                        return _offset_MethodBeingCompiledName;
                    }
                }

                private int Offset_MethodBeingCompiledNameSignature
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNameSignature == -1)
                        {
                            _offset_MethodBeingCompiledNameSignature = Offset_MethodBeingCompiledName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledName);
                        }

                        return _offset_MethodBeingCompiledNameSignature;
                    }
                }

                private int Offset_InlinerNamespace
                {
                    get
                    {
                        if (_offset_InlinerNamespace == -1)
                        {
                            _offset_InlinerNamespace = Offset_MethodBeingCompiledNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNameSignature);
                        }

                        return _offset_InlinerNamespace;
                    }
                }

                private int Offset_InlinerName
                {
                    get
                    {
                        if (_offset_InlinerName == -1)
                        {
                            _offset_InlinerName = Offset_InlinerNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerNamespace);
                        }

                        return _offset_InlinerName;
                    }
                }

                private int Offset_InlinerNameSignature
                {
                    get
                    {
                        if (_offset_InlinerNameSignature == -1)
                        {
                            _offset_InlinerNameSignature = Offset_InlinerName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerName);
                        }

                        return _offset_InlinerNameSignature;
                    }
                }

                private int Offset_InlineeNamespace
                {
                    get
                    {
                        if (_offset_InlineeNamespace == -1)
                        {
                            _offset_InlineeNamespace = Offset_InlinerNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerNameSignature);
                        }

                        return _offset_InlineeNamespace;
                    }
                }

                private int Offset_InlineeName
                {
                    get
                    {
                        if (_offset_InlineeName == -1)
                        {
                            _offset_InlineeName = Offset_InlineeNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeNamespace);
                        }

                        return _offset_InlineeName;
                    }
                }

                private int Offset_InlineeNameSignature
                {
                    get
                    {
                        if (_offset_InlineeNameSignature == -1)
                        {
                            _offset_InlineeNameSignature = Offset_InlineeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeName);
                        }

                        return _offset_InlineeNameSignature;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_InlineeNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeNameSignature);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodBeingCompiledNamespace field.
                /// </summary>
                public string MethodBeingCompiledNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNamespace..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledName field.
                /// </summary>
                public string MethodBeingCompiledName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledName..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledNameSignature field.
                /// </summary>
                public string MethodBeingCompiledNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNameSignature..]);

                /// <summary>
                /// Retrieves the InlinerNamespace field.
                /// </summary>
                public string InlinerNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerNamespace..]);

                /// <summary>
                /// Retrieves the InlinerName field.
                /// </summary>
                public string InlinerName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerName..]);

                /// <summary>
                /// Retrieves the InlinerNameSignature field.
                /// </summary>
                public string InlinerNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerNameSignature..]);

                /// <summary>
                /// Retrieves the InlineeNamespace field.
                /// </summary>
                public string InlineeNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeNamespace..]);

                /// <summary>
                /// Retrieves the InlineeName field.
                /// </summary>
                public string InlineeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeName..]);

                /// <summary>
                /// Retrieves the InlineeNameSignature field.
                /// </summary>
                public string InlineeNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeNameSignature..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodInliningSucceededData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodInliningSucceededData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodBeingCompiledNamespace = -1;
                    _offset_MethodBeingCompiledName = -1;
                    _offset_MethodBeingCompiledNameSignature = -1;
                    _offset_InlinerNamespace = -1;
                    _offset_InlinerName = -1;
                    _offset_InlinerNameSignature = -1;
                    _offset_InlineeNamespace = -1;
                    _offset_InlineeName = -1;
                    _offset_InlineeNameSignature = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodInliningFailed event.
        /// </summary>
        public readonly ref struct MethodInliningFailedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodInliningFailed";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 186,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.InliningFailed,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitTracingKeyword
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
            public MethodInliningFailedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodInliningFailedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodInliningFailedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodInliningFailed event.
            /// </summary>
            public ref struct MethodInliningFailedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodBeingCompiledNamespace;
                private int _offset_MethodBeingCompiledName;
                private int _offset_MethodBeingCompiledNameSignature;
                private int _offset_InlinerNamespace;
                private int _offset_InlinerName;
                private int _offset_InlinerNameSignature;
                private int _offset_InlineeNamespace;
                private int _offset_InlineeName;
                private int _offset_InlineeNameSignature;
                private int _offset_FailAlways;
                private int _offset_FailReason;
                private int _offset_ClrInstanceID;

                private int Offset_MethodBeingCompiledNamespace
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNamespace == -1)
                        {
                            _offset_MethodBeingCompiledNamespace = 0;
                        }

                        return _offset_MethodBeingCompiledNamespace;
                    }
                }

                private int Offset_MethodBeingCompiledName
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledName == -1)
                        {
                            _offset_MethodBeingCompiledName = Offset_MethodBeingCompiledNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNamespace);
                        }

                        return _offset_MethodBeingCompiledName;
                    }
                }

                private int Offset_MethodBeingCompiledNameSignature
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNameSignature == -1)
                        {
                            _offset_MethodBeingCompiledNameSignature = Offset_MethodBeingCompiledName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledName);
                        }

                        return _offset_MethodBeingCompiledNameSignature;
                    }
                }

                private int Offset_InlinerNamespace
                {
                    get
                    {
                        if (_offset_InlinerNamespace == -1)
                        {
                            _offset_InlinerNamespace = Offset_MethodBeingCompiledNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNameSignature);
                        }

                        return _offset_InlinerNamespace;
                    }
                }

                private int Offset_InlinerName
                {
                    get
                    {
                        if (_offset_InlinerName == -1)
                        {
                            _offset_InlinerName = Offset_InlinerNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerNamespace);
                        }

                        return _offset_InlinerName;
                    }
                }

                private int Offset_InlinerNameSignature
                {
                    get
                    {
                        if (_offset_InlinerNameSignature == -1)
                        {
                            _offset_InlinerNameSignature = Offset_InlinerName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerName);
                        }

                        return _offset_InlinerNameSignature;
                    }
                }

                private int Offset_InlineeNamespace
                {
                    get
                    {
                        if (_offset_InlineeNamespace == -1)
                        {
                            _offset_InlineeNamespace = Offset_InlinerNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlinerNameSignature);
                        }

                        return _offset_InlineeNamespace;
                    }
                }

                private int Offset_InlineeName
                {
                    get
                    {
                        if (_offset_InlineeName == -1)
                        {
                            _offset_InlineeName = Offset_InlineeNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeNamespace);
                        }

                        return _offset_InlineeName;
                    }
                }

                private int Offset_InlineeNameSignature
                {
                    get
                    {
                        if (_offset_InlineeNameSignature == -1)
                        {
                            _offset_InlineeNameSignature = Offset_InlineeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeName);
                        }

                        return _offset_InlineeNameSignature;
                    }
                }

                private int Offset_FailAlways
                {
                    get
                    {
                        if (_offset_FailAlways == -1)
                        {
                            _offset_FailAlways = Offset_InlineeNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_InlineeNameSignature);
                        }

                        return _offset_FailAlways;
                    }
                }

                private int Offset_FailReason
                {
                    get
                    {
                        if (_offset_FailReason == -1)
                        {
                            _offset_FailReason = Offset_FailAlways + 1;
                        }

                        return _offset_FailReason;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FailReason + EtwEvent.AnsiStringEnumerable.AnsiStringEnumerator.StringLength(_etwEvent.Data, Offset_FailReason);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodBeingCompiledNamespace field.
                /// </summary>
                public string MethodBeingCompiledNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNamespace..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledName field.
                /// </summary>
                public string MethodBeingCompiledName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledName..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledNameSignature field.
                /// </summary>
                public string MethodBeingCompiledNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNameSignature..]);

                /// <summary>
                /// Retrieves the InlinerNamespace field.
                /// </summary>
                public string InlinerNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerNamespace..]);

                /// <summary>
                /// Retrieves the InlinerName field.
                /// </summary>
                public string InlinerName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerName..]);

                /// <summary>
                /// Retrieves the InlinerNameSignature field.
                /// </summary>
                public string InlinerNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlinerNameSignature..]);

                /// <summary>
                /// Retrieves the InlineeNamespace field.
                /// </summary>
                public string InlineeNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeNamespace..]);

                /// <summary>
                /// Retrieves the InlineeName field.
                /// </summary>
                public string InlineeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeName..]);

                /// <summary>
                /// Retrieves the InlineeNameSignature field.
                /// </summary>
                public string InlineeNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_InlineeNameSignature..]);

                /// <summary>
                /// Retrieves the FailAlways field.
                /// </summary>
                public bool FailAlways => _etwEvent.Data[Offset_FailAlways] != 0;

                /// <summary>
                /// Retrieves the FailReason field.
                /// </summary>
                public string FailReason => System.Text.Encoding.ASCII.GetString(_etwEvent.Data[Offset_FailReason..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodInliningFailedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodInliningFailedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodBeingCompiledNamespace = -1;
                    _offset_MethodBeingCompiledName = -1;
                    _offset_MethodBeingCompiledNameSignature = -1;
                    _offset_InlinerNamespace = -1;
                    _offset_InlinerName = -1;
                    _offset_InlinerNameSignature = -1;
                    _offset_InlineeNamespace = -1;
                    _offset_InlineeName = -1;
                    _offset_InlineeNameSignature = -1;
                    _offset_FailAlways = -1;
                    _offset_FailReason = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a RuntimeStart event.
        /// </summary>
        public readonly ref struct RuntimeStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "RuntimeStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 187,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.Runtime,
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
            public RuntimeStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new RuntimeStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public RuntimeStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a RuntimeStart event.
            /// </summary>
            public ref struct RuntimeStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_Sku;
                private int _offset_BclMajorVersion;
                private int _offset_BclMinorVersion;
                private int _offset_BclBuildNumber;
                private int _offset_BclQfeNumber;
                private int _offset_VMMajorVersion;
                private int _offset_VMMinorVersion;
                private int _offset_VMBuildNumber;
                private int _offset_VMQfeNumber;
                private int _offset_StartupFlags;
                private int _offset_StartupMode;
                private int _offset_CommandLine;
                private int _offset_ComObjectGuid;
                private int _offset_RuntimeDllPath;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Sku
                {
                    get
                    {
                        if (_offset_Sku == -1)
                        {
                            _offset_Sku = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Sku;
                    }
                }

                private int Offset_BclMajorVersion
                {
                    get
                    {
                        if (_offset_BclMajorVersion == -1)
                        {
                            _offset_BclMajorVersion = Offset_Sku + 2;
                        }

                        return _offset_BclMajorVersion;
                    }
                }

                private int Offset_BclMinorVersion
                {
                    get
                    {
                        if (_offset_BclMinorVersion == -1)
                        {
                            _offset_BclMinorVersion = Offset_BclMajorVersion + 2;
                        }

                        return _offset_BclMinorVersion;
                    }
                }

                private int Offset_BclBuildNumber
                {
                    get
                    {
                        if (_offset_BclBuildNumber == -1)
                        {
                            _offset_BclBuildNumber = Offset_BclMinorVersion + 2;
                        }

                        return _offset_BclBuildNumber;
                    }
                }

                private int Offset_BclQfeNumber
                {
                    get
                    {
                        if (_offset_BclQfeNumber == -1)
                        {
                            _offset_BclQfeNumber = Offset_BclBuildNumber + 2;
                        }

                        return _offset_BclQfeNumber;
                    }
                }

                private int Offset_VMMajorVersion
                {
                    get
                    {
                        if (_offset_VMMajorVersion == -1)
                        {
                            _offset_VMMajorVersion = Offset_BclQfeNumber + 2;
                        }

                        return _offset_VMMajorVersion;
                    }
                }

                private int Offset_VMMinorVersion
                {
                    get
                    {
                        if (_offset_VMMinorVersion == -1)
                        {
                            _offset_VMMinorVersion = Offset_VMMajorVersion + 2;
                        }

                        return _offset_VMMinorVersion;
                    }
                }

                private int Offset_VMBuildNumber
                {
                    get
                    {
                        if (_offset_VMBuildNumber == -1)
                        {
                            _offset_VMBuildNumber = Offset_VMMinorVersion + 2;
                        }

                        return _offset_VMBuildNumber;
                    }
                }

                private int Offset_VMQfeNumber
                {
                    get
                    {
                        if (_offset_VMQfeNumber == -1)
                        {
                            _offset_VMQfeNumber = Offset_VMBuildNumber + 2;
                        }

                        return _offset_VMQfeNumber;
                    }
                }

                private int Offset_StartupFlags
                {
                    get
                    {
                        if (_offset_StartupFlags == -1)
                        {
                            _offset_StartupFlags = Offset_VMQfeNumber + 2;
                        }

                        return _offset_StartupFlags;
                    }
                }

                private int Offset_StartupMode
                {
                    get
                    {
                        if (_offset_StartupMode == -1)
                        {
                            _offset_StartupMode = Offset_StartupFlags + 4;
                        }

                        return _offset_StartupMode;
                    }
                }

                private int Offset_CommandLine
                {
                    get
                    {
                        if (_offset_CommandLine == -1)
                        {
                            _offset_CommandLine = Offset_StartupMode + 1;
                        }

                        return _offset_CommandLine;
                    }
                }

                private int Offset_ComObjectGuid
                {
                    get
                    {
                        if (_offset_ComObjectGuid == -1)
                        {
                            _offset_ComObjectGuid = Offset_CommandLine + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CommandLine);
                        }

                        return _offset_ComObjectGuid;
                    }
                }

                private int Offset_RuntimeDllPath
                {
                    get
                    {
                        if (_offset_RuntimeDllPath == -1)
                        {
                            _offset_RuntimeDllPath = Offset_ComObjectGuid + 16;
                        }

                        return _offset_RuntimeDllPath;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Sku field.
                /// </summary>
                public RuntimeSkuMap Sku => (RuntimeSkuMap)BitConverter.ToUInt16(_etwEvent.Data[Offset_Sku..]);

                /// <summary>
                /// Retrieves the BclMajorVersion field.
                /// </summary>
                public ushort BclMajorVersion => BitConverter.ToUInt16(_etwEvent.Data[Offset_BclMajorVersion..]);

                /// <summary>
                /// Retrieves the BclMinorVersion field.
                /// </summary>
                public ushort BclMinorVersion => BitConverter.ToUInt16(_etwEvent.Data[Offset_BclMinorVersion..]);

                /// <summary>
                /// Retrieves the BclBuildNumber field.
                /// </summary>
                public ushort BclBuildNumber => BitConverter.ToUInt16(_etwEvent.Data[Offset_BclBuildNumber..]);

                /// <summary>
                /// Retrieves the BclQfeNumber field.
                /// </summary>
                public ushort BclQfeNumber => BitConverter.ToUInt16(_etwEvent.Data[Offset_BclQfeNumber..]);

                /// <summary>
                /// Retrieves the VMMajorVersion field.
                /// </summary>
                public ushort VMMajorVersion => BitConverter.ToUInt16(_etwEvent.Data[Offset_VMMajorVersion..]);

                /// <summary>
                /// Retrieves the VMMinorVersion field.
                /// </summary>
                public ushort VMMinorVersion => BitConverter.ToUInt16(_etwEvent.Data[Offset_VMMinorVersion..]);

                /// <summary>
                /// Retrieves the VMBuildNumber field.
                /// </summary>
                public ushort VMBuildNumber => BitConverter.ToUInt16(_etwEvent.Data[Offset_VMBuildNumber..]);

                /// <summary>
                /// Retrieves the VMQfeNumber field.
                /// </summary>
                public ushort VMQfeNumber => BitConverter.ToUInt16(_etwEvent.Data[Offset_VMQfeNumber..]);

                /// <summary>
                /// Retrieves the StartupFlags field.
                /// </summary>
                public StartupFlagsMap StartupFlags => (StartupFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_StartupFlags..]);

                /// <summary>
                /// Retrieves the StartupMode field.
                /// </summary>
                public StartupModeMap StartupMode => (StartupModeMap)_etwEvent.Data[Offset_StartupMode];

                /// <summary>
                /// Retrieves the CommandLine field.
                /// </summary>
                public string CommandLine => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CommandLine..]);

                /// <summary>
                /// Retrieves the ComObjectGuid field.
                /// </summary>
                public Guid ComObjectGuid => new(_etwEvent.Data[Offset_ComObjectGuid..]);

                /// <summary>
                /// Retrieves the RuntimeDllPath field.
                /// </summary>
                public string RuntimeDllPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_RuntimeDllPath..]);

                /// <summary>
                /// Creates a new RuntimeStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public RuntimeStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_Sku = -1;
                    _offset_BclMajorVersion = -1;
                    _offset_BclMinorVersion = -1;
                    _offset_BclBuildNumber = -1;
                    _offset_BclQfeNumber = -1;
                    _offset_VMMajorVersion = -1;
                    _offset_VMMinorVersion = -1;
                    _offset_VMBuildNumber = -1;
                    _offset_VMQfeNumber = -1;
                    _offset_StartupFlags = -1;
                    _offset_StartupMode = -1;
                    _offset_CommandLine = -1;
                    _offset_ComObjectGuid = -1;
                    _offset_RuntimeDllPath = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodTailCallSucceeded event.
        /// </summary>
        public readonly ref struct MethodTailCallSucceededEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodTailCallSucceeded";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 188,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.TailCallSucceeded,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitTracingKeyword
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
            public MethodTailCallSucceededData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodTailCallSucceededEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodTailCallSucceededEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodTailCallSucceeded event.
            /// </summary>
            public ref struct MethodTailCallSucceededData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodBeingCompiledNamespace;
                private int _offset_MethodBeingCompiledName;
                private int _offset_MethodBeingCompiledNameSignature;
                private int _offset_CallerNamespace;
                private int _offset_CallerName;
                private int _offset_CallerNameSignature;
                private int _offset_CalleeNamespace;
                private int _offset_CalleeName;
                private int _offset_CalleeNameSignature;
                private int _offset_TailPrefix;
                private int _offset_TailCallType;
                private int _offset_ClrInstanceID;

                private int Offset_MethodBeingCompiledNamespace
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNamespace == -1)
                        {
                            _offset_MethodBeingCompiledNamespace = 0;
                        }

                        return _offset_MethodBeingCompiledNamespace;
                    }
                }

                private int Offset_MethodBeingCompiledName
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledName == -1)
                        {
                            _offset_MethodBeingCompiledName = Offset_MethodBeingCompiledNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNamespace);
                        }

                        return _offset_MethodBeingCompiledName;
                    }
                }

                private int Offset_MethodBeingCompiledNameSignature
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNameSignature == -1)
                        {
                            _offset_MethodBeingCompiledNameSignature = Offset_MethodBeingCompiledName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledName);
                        }

                        return _offset_MethodBeingCompiledNameSignature;
                    }
                }

                private int Offset_CallerNamespace
                {
                    get
                    {
                        if (_offset_CallerNamespace == -1)
                        {
                            _offset_CallerNamespace = Offset_MethodBeingCompiledNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNameSignature);
                        }

                        return _offset_CallerNamespace;
                    }
                }

                private int Offset_CallerName
                {
                    get
                    {
                        if (_offset_CallerName == -1)
                        {
                            _offset_CallerName = Offset_CallerNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerNamespace);
                        }

                        return _offset_CallerName;
                    }
                }

                private int Offset_CallerNameSignature
                {
                    get
                    {
                        if (_offset_CallerNameSignature == -1)
                        {
                            _offset_CallerNameSignature = Offset_CallerName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerName);
                        }

                        return _offset_CallerNameSignature;
                    }
                }

                private int Offset_CalleeNamespace
                {
                    get
                    {
                        if (_offset_CalleeNamespace == -1)
                        {
                            _offset_CalleeNamespace = Offset_CallerNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerNameSignature);
                        }

                        return _offset_CalleeNamespace;
                    }
                }

                private int Offset_CalleeName
                {
                    get
                    {
                        if (_offset_CalleeName == -1)
                        {
                            _offset_CalleeName = Offset_CalleeNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeNamespace);
                        }

                        return _offset_CalleeName;
                    }
                }

                private int Offset_CalleeNameSignature
                {
                    get
                    {
                        if (_offset_CalleeNameSignature == -1)
                        {
                            _offset_CalleeNameSignature = Offset_CalleeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeName);
                        }

                        return _offset_CalleeNameSignature;
                    }
                }

                private int Offset_TailPrefix
                {
                    get
                    {
                        if (_offset_TailPrefix == -1)
                        {
                            _offset_TailPrefix = Offset_CalleeNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeNameSignature);
                        }

                        return _offset_TailPrefix;
                    }
                }

                private int Offset_TailCallType
                {
                    get
                    {
                        if (_offset_TailCallType == -1)
                        {
                            _offset_TailCallType = Offset_TailPrefix + 1;
                        }

                        return _offset_TailCallType;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_TailCallType + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodBeingCompiledNamespace field.
                /// </summary>
                public string MethodBeingCompiledNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNamespace..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledName field.
                /// </summary>
                public string MethodBeingCompiledName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledName..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledNameSignature field.
                /// </summary>
                public string MethodBeingCompiledNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNameSignature..]);

                /// <summary>
                /// Retrieves the CallerNamespace field.
                /// </summary>
                public string CallerNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerNamespace..]);

                /// <summary>
                /// Retrieves the CallerName field.
                /// </summary>
                public string CallerName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerName..]);

                /// <summary>
                /// Retrieves the CallerNameSignature field.
                /// </summary>
                public string CallerNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerNameSignature..]);

                /// <summary>
                /// Retrieves the CalleeNamespace field.
                /// </summary>
                public string CalleeNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeNamespace..]);

                /// <summary>
                /// Retrieves the CalleeName field.
                /// </summary>
                public string CalleeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeName..]);

                /// <summary>
                /// Retrieves the CalleeNameSignature field.
                /// </summary>
                public string CalleeNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeNameSignature..]);

                /// <summary>
                /// Retrieves the TailPrefix field.
                /// </summary>
                public bool TailPrefix => _etwEvent.Data[Offset_TailPrefix] != 0;

                /// <summary>
                /// Retrieves the TailCallType field.
                /// </summary>
                public TailCallTypeMap TailCallType => (TailCallTypeMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_TailCallType..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodTailCallSucceededData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodTailCallSucceededData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodBeingCompiledNamespace = -1;
                    _offset_MethodBeingCompiledName = -1;
                    _offset_MethodBeingCompiledNameSignature = -1;
                    _offset_CallerNamespace = -1;
                    _offset_CallerName = -1;
                    _offset_CallerNameSignature = -1;
                    _offset_CalleeNamespace = -1;
                    _offset_CalleeName = -1;
                    _offset_CalleeNameSignature = -1;
                    _offset_TailPrefix = -1;
                    _offset_TailCallType = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodTailCallFailed event.
        /// </summary>
        public readonly ref struct MethodTailCallFailedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodTailCallFailed";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 189,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.TailCallFailed,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitTracingKeyword
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
            public MethodTailCallFailedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodTailCallFailedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodTailCallFailedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodTailCallFailed event.
            /// </summary>
            public ref struct MethodTailCallFailedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodBeingCompiledNamespace;
                private int _offset_MethodBeingCompiledName;
                private int _offset_MethodBeingCompiledNameSignature;
                private int _offset_CallerNamespace;
                private int _offset_CallerName;
                private int _offset_CallerNameSignature;
                private int _offset_CalleeNamespace;
                private int _offset_CalleeName;
                private int _offset_CalleeNameSignature;
                private int _offset_TailPrefix;
                private int _offset_FailReason;
                private int _offset_ClrInstanceID;

                private int Offset_MethodBeingCompiledNamespace
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNamespace == -1)
                        {
                            _offset_MethodBeingCompiledNamespace = 0;
                        }

                        return _offset_MethodBeingCompiledNamespace;
                    }
                }

                private int Offset_MethodBeingCompiledName
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledName == -1)
                        {
                            _offset_MethodBeingCompiledName = Offset_MethodBeingCompiledNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNamespace);
                        }

                        return _offset_MethodBeingCompiledName;
                    }
                }

                private int Offset_MethodBeingCompiledNameSignature
                {
                    get
                    {
                        if (_offset_MethodBeingCompiledNameSignature == -1)
                        {
                            _offset_MethodBeingCompiledNameSignature = Offset_MethodBeingCompiledName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledName);
                        }

                        return _offset_MethodBeingCompiledNameSignature;
                    }
                }

                private int Offset_CallerNamespace
                {
                    get
                    {
                        if (_offset_CallerNamespace == -1)
                        {
                            _offset_CallerNamespace = Offset_MethodBeingCompiledNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodBeingCompiledNameSignature);
                        }

                        return _offset_CallerNamespace;
                    }
                }

                private int Offset_CallerName
                {
                    get
                    {
                        if (_offset_CallerName == -1)
                        {
                            _offset_CallerName = Offset_CallerNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerNamespace);
                        }

                        return _offset_CallerName;
                    }
                }

                private int Offset_CallerNameSignature
                {
                    get
                    {
                        if (_offset_CallerNameSignature == -1)
                        {
                            _offset_CallerNameSignature = Offset_CallerName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerName);
                        }

                        return _offset_CallerNameSignature;
                    }
                }

                private int Offset_CalleeNamespace
                {
                    get
                    {
                        if (_offset_CalleeNamespace == -1)
                        {
                            _offset_CalleeNamespace = Offset_CallerNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CallerNameSignature);
                        }

                        return _offset_CalleeNamespace;
                    }
                }

                private int Offset_CalleeName
                {
                    get
                    {
                        if (_offset_CalleeName == -1)
                        {
                            _offset_CalleeName = Offset_CalleeNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeNamespace);
                        }

                        return _offset_CalleeName;
                    }
                }

                private int Offset_CalleeNameSignature
                {
                    get
                    {
                        if (_offset_CalleeNameSignature == -1)
                        {
                            _offset_CalleeNameSignature = Offset_CalleeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeName);
                        }

                        return _offset_CalleeNameSignature;
                    }
                }

                private int Offset_TailPrefix
                {
                    get
                    {
                        if (_offset_TailPrefix == -1)
                        {
                            _offset_TailPrefix = Offset_CalleeNameSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_CalleeNameSignature);
                        }

                        return _offset_TailPrefix;
                    }
                }

                private int Offset_FailReason
                {
                    get
                    {
                        if (_offset_FailReason == -1)
                        {
                            _offset_FailReason = Offset_TailPrefix + 1;
                        }

                        return _offset_FailReason;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FailReason + EtwEvent.AnsiStringEnumerable.AnsiStringEnumerator.StringLength(_etwEvent.Data, Offset_FailReason);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodBeingCompiledNamespace field.
                /// </summary>
                public string MethodBeingCompiledNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNamespace..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledName field.
                /// </summary>
                public string MethodBeingCompiledName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledName..]);

                /// <summary>
                /// Retrieves the MethodBeingCompiledNameSignature field.
                /// </summary>
                public string MethodBeingCompiledNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodBeingCompiledNameSignature..]);

                /// <summary>
                /// Retrieves the CallerNamespace field.
                /// </summary>
                public string CallerNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerNamespace..]);

                /// <summary>
                /// Retrieves the CallerName field.
                /// </summary>
                public string CallerName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerName..]);

                /// <summary>
                /// Retrieves the CallerNameSignature field.
                /// </summary>
                public string CallerNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CallerNameSignature..]);

                /// <summary>
                /// Retrieves the CalleeNamespace field.
                /// </summary>
                public string CalleeNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeNamespace..]);

                /// <summary>
                /// Retrieves the CalleeName field.
                /// </summary>
                public string CalleeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeName..]);

                /// <summary>
                /// Retrieves the CalleeNameSignature field.
                /// </summary>
                public string CalleeNameSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_CalleeNameSignature..]);

                /// <summary>
                /// Retrieves the TailPrefix field.
                /// </summary>
                public bool TailPrefix => _etwEvent.Data[Offset_TailPrefix] != 0;

                /// <summary>
                /// Retrieves the FailReason field.
                /// </summary>
                public string FailReason => System.Text.Encoding.ASCII.GetString(_etwEvent.Data[Offset_FailReason..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodTailCallFailedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodTailCallFailedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodBeingCompiledNamespace = -1;
                    _offset_MethodBeingCompiledName = -1;
                    _offset_MethodBeingCompiledNameSignature = -1;
                    _offset_CallerNamespace = -1;
                    _offset_CallerName = -1;
                    _offset_CallerNameSignature = -1;
                    _offset_CalleeNamespace = -1;
                    _offset_CalleeName = -1;
                    _offset_CalleeNameSignature = -1;
                    _offset_TailPrefix = -1;
                    _offset_FailReason = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodMethodILToNativeMap event.
        /// </summary>
        public readonly ref struct MethodMethodILToNativeMapEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodMethodILToNativeMap";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 190,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.MethodILToNativeMap,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JittedMethodILToNativeMapKeyword
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
            public MethodMethodILToNativeMapData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodMethodILToNativeMapEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodMethodILToNativeMapEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodMethodILToNativeMap event.
            /// </summary>
            public ref struct MethodMethodILToNativeMapData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ReJITID;
                private int _offset_MethodExtent;
                private int _offset_CountOfMapEntries;
                private int _offset_ILOffsets;
                private int _offset_NativeOffsets;
                private int _offset_ClrInstanceID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ReJITID
                {
                    get
                    {
                        if (_offset_ReJITID == -1)
                        {
                            _offset_ReJITID = Offset_MethodID + 8;
                        }

                        return _offset_ReJITID;
                    }
                }

                private int Offset_MethodExtent
                {
                    get
                    {
                        if (_offset_MethodExtent == -1)
                        {
                            _offset_MethodExtent = Offset_ReJITID + 8;
                        }

                        return _offset_MethodExtent;
                    }
                }

                private int Offset_CountOfMapEntries
                {
                    get
                    {
                        if (_offset_CountOfMapEntries == -1)
                        {
                            _offset_CountOfMapEntries = Offset_MethodExtent + 1;
                        }

                        return _offset_CountOfMapEntries;
                    }
                }

                private int Offset_ILOffsets
                {
                    get
                    {
                        if (_offset_ILOffsets == -1)
                        {
                            _offset_ILOffsets = Offset_CountOfMapEntries + 2;
                        }

                        return _offset_ILOffsets;
                    }
                }

                private int Offset_NativeOffsets
                {
                    get
                    {
                        if (_offset_NativeOffsets == -1)
                        {
                            _offset_NativeOffsets = Offset_ILOffsets + (4 * (int)CountOfMapEntries);
                        }

                        return _offset_NativeOffsets;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_NativeOffsets + (4 * (int)CountOfMapEntries);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ReJITID field.
                /// </summary>
                public ulong ReJITID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ReJITID..]);

                /// <summary>
                /// Retrieves the MethodExtent field.
                /// </summary>
                public byte MethodExtent => _etwEvent.Data[Offset_MethodExtent];

                /// <summary>
                /// Retrieves the CountOfMapEntries field.
                /// </summary>
                public ushort CountOfMapEntries => BitConverter.ToUInt16(_etwEvent.Data[Offset_CountOfMapEntries..]);

                /// <summary>
                /// Retrieves the ILOffsets field.
                /// </summary>
                public EtwEvent.StructEnumerable<uint> ILOffsets => new(_etwEvent, Offset_ILOffsets, CountOfMapEntries);

                /// <summary>
                /// Retrieves the NativeOffsets field.
                /// </summary>
                public EtwEvent.StructEnumerable<uint> NativeOffsets => new(_etwEvent, Offset_NativeOffsets, CountOfMapEntries);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodMethodILToNativeMapData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodMethodILToNativeMapData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ReJITID = -1;
                    _offset_MethodExtent = -1;
                    _offset_CountOfMapEntries = -1;
                    _offset_ILOffsets = -1;
                    _offset_NativeOffsets = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCIncreaseMemoryPressure event.
        /// </summary>
        public readonly ref struct GCIncreaseMemoryPressureEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCIncreaseMemoryPressure";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 200,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.IncreaseMemoryPressure,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCIncreaseMemoryPressureData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCIncreaseMemoryPressureEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCIncreaseMemoryPressureEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCIncreaseMemoryPressure event.
            /// </summary>
            public ref struct GCIncreaseMemoryPressureData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_BytesAllocated;
                private int _offset_ClrInstanceID;

                private int Offset_BytesAllocated
                {
                    get
                    {
                        if (_offset_BytesAllocated == -1)
                        {
                            _offset_BytesAllocated = 0;
                        }

                        return _offset_BytesAllocated;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_BytesAllocated + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the BytesAllocated field.
                /// </summary>
                public ulong BytesAllocated => BitConverter.ToUInt64(_etwEvent.Data[Offset_BytesAllocated..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCIncreaseMemoryPressureData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCIncreaseMemoryPressureData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_BytesAllocated = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCDecreaseMemoryPressure event.
        /// </summary>
        public readonly ref struct GCDecreaseMemoryPressureEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCDecreaseMemoryPressure";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 201,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.DecreaseMemoryPressure,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCDecreaseMemoryPressureData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCDecreaseMemoryPressureEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCDecreaseMemoryPressureEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCDecreaseMemoryPressure event.
            /// </summary>
            public ref struct GCDecreaseMemoryPressureData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_BytesFreed;
                private int _offset_ClrInstanceID;

                private int Offset_BytesFreed
                {
                    get
                    {
                        if (_offset_BytesFreed == -1)
                        {
                            _offset_BytesFreed = 0;
                        }

                        return _offset_BytesFreed;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_BytesFreed + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the BytesFreed field.
                /// </summary>
                public ulong BytesFreed => BitConverter.ToUInt64(_etwEvent.Data[Offset_BytesFreed..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCDecreaseMemoryPressureData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCDecreaseMemoryPressureData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_BytesFreed = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCMark event.
        /// </summary>
        public readonly ref struct GCMarkEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCMark";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 202,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.Mark,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCMarkData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCMarkEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCMarkEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCMark event.
            /// </summary>
            public ref struct GCMarkData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_HeapNum;
                private int _offset_ClrInstanceID;
                private int _offset_Type;
                private int _offset_Bytes;

                private int Offset_HeapNum
                {
                    get
                    {
                        if (_offset_HeapNum == -1)
                        {
                            _offset_HeapNum = 0;
                        }

                        return _offset_HeapNum;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_HeapNum + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_Type
                {
                    get
                    {
                        if (_offset_Type == -1)
                        {
                            _offset_Type = Offset_ClrInstanceID + 2;
                        }

                        return _offset_Type;
                    }
                }

                private int Offset_Bytes
                {
                    get
                    {
                        if (_offset_Bytes == -1)
                        {
                            _offset_Bytes = Offset_Type + 4;
                        }

                        return _offset_Bytes;
                    }
                }

                /// <summary>
                /// Retrieves the HeapNum field.
                /// </summary>
                public uint HeapNum => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapNum..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the Type field.
                /// </summary>
                public GCRootKindMap Type => (GCRootKindMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Type..]);

                /// <summary>
                /// Retrieves the Bytes field.
                /// </summary>
                public ulong Bytes => BitConverter.ToUInt64(_etwEvent.Data[Offset_Bytes..]);

                /// <summary>
                /// Creates a new GCMarkData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCMarkData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_HeapNum = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_Type = -1;
                    _offset_Bytes = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCLoaded event.
        /// </summary>
        public readonly ref struct GCLoadedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCLoaded";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 206,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCLoaded,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCLoadedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCLoadedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCLoadedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCLoaded event.
            /// </summary>
            public ref struct GCLoadedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_GCName;
                private int _offset_ClrInstanceID;

                private int Offset_GCName
                {
                    get
                    {
                        if (_offset_GCName == -1)
                        {
                            _offset_GCName = 0;
                        }

                        return _offset_GCName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_GCName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_GCName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the GCName field.
                /// </summary>
                public string GCName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_GCName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCLoadedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCLoadedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_GCName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a DebugIPCEventStart event.
        /// </summary>
        public readonly ref struct DebugIPCEventStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "DebugIPCEventStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 240,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.DebugIPCEvent,
                Keyword = (ulong)Keywords.DebuggerKeyword
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
            /// Creates a new DebugIPCEventStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public DebugIPCEventStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a DebugIPCEventStop event.
        /// </summary>
        public readonly ref struct DebugIPCEventStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "DebugIPCEventStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 241,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.DebugIPCEvent,
                Keyword = (ulong)Keywords.DebuggerKeyword
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
            /// Creates a new DebugIPCEventStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public DebugIPCEventStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a DebugExceptionProcessingStart event.
        /// </summary>
        public readonly ref struct DebugExceptionProcessingStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "DebugExceptionProcessingStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 242,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.DebugExceptionProcessing,
                Keyword = (ulong)Keywords.DebuggerKeyword
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
            /// Creates a new DebugExceptionProcessingStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public DebugExceptionProcessingStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a DebugExceptionProcessingStop event.
        /// </summary>
        public readonly ref struct DebugExceptionProcessingStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "DebugExceptionProcessingStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 243,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.DebugExceptionProcessing,
                Keyword = (ulong)Keywords.DebuggerKeyword
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
            /// Creates a new DebugExceptionProcessingStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public DebugExceptionProcessingStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a ExceptionCatchStart event.
        /// </summary>
        public readonly ref struct ExceptionCatchStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionCatchStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 250,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ExceptionCatch,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            public ExceptionCatchStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ExceptionCatchStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionCatchStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ExceptionCatchStart event.
            /// </summary>
            public ref struct ExceptionCatchStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_EntryEIP;
                private int _offset_MethodID;
                private int _offset_MethodName;
                private int _offset_ClrInstanceID;

                private int Offset_EntryEIP
                {
                    get
                    {
                        if (_offset_EntryEIP == -1)
                        {
                            _offset_EntryEIP = 0;
                        }

                        return _offset_EntryEIP;
                    }
                }

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = Offset_EntryEIP + 8;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodID + 8;
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the EntryEIP field.
                /// </summary>
                public ulong EntryEIP => BitConverter.ToUInt64(_etwEvent.Data[Offset_EntryEIP..]);

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ExceptionCatchStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ExceptionCatchStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_EntryEIP = -1;
                    _offset_MethodID = -1;
                    _offset_MethodName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ExceptionCatchStop event.
        /// </summary>
        public readonly ref struct ExceptionCatchStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionCatchStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 251,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ExceptionCatch,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            /// Creates a new ExceptionCatchStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionCatchStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a ExceptionFinallyStart event.
        /// </summary>
        public readonly ref struct ExceptionFinallyStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionFinallyStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 252,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ExceptionFinally,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            public ExceptionFinallyStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ExceptionFinallyStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionFinallyStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ExceptionFinallyStart event.
            /// </summary>
            public ref struct ExceptionFinallyStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_EntryEIP;
                private int _offset_MethodID;
                private int _offset_MethodName;
                private int _offset_ClrInstanceID;

                private int Offset_EntryEIP
                {
                    get
                    {
                        if (_offset_EntryEIP == -1)
                        {
                            _offset_EntryEIP = 0;
                        }

                        return _offset_EntryEIP;
                    }
                }

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = Offset_EntryEIP + 8;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodID + 8;
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the EntryEIP field.
                /// </summary>
                public ulong EntryEIP => BitConverter.ToUInt64(_etwEvent.Data[Offset_EntryEIP..]);

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ExceptionFinallyStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ExceptionFinallyStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_EntryEIP = -1;
                    _offset_MethodID = -1;
                    _offset_MethodName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ExceptionFinallyStop event.
        /// </summary>
        public readonly ref struct ExceptionFinallyStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionFinallyStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 253,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ExceptionFinally,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            /// Creates a new ExceptionFinallyStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionFinallyStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a ExceptionFilterStart event.
        /// </summary>
        public readonly ref struct ExceptionFilterStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionFilterStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 254,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.ExceptionFilter,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            public ExceptionFilterStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ExceptionFilterStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionFilterStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ExceptionFilterStart event.
            /// </summary>
            public ref struct ExceptionFilterStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_EntryEIP;
                private int _offset_MethodID;
                private int _offset_MethodName;
                private int _offset_ClrInstanceID;

                private int Offset_EntryEIP
                {
                    get
                    {
                        if (_offset_EntryEIP == -1)
                        {
                            _offset_EntryEIP = 0;
                        }

                        return _offset_EntryEIP;
                    }
                }

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = Offset_EntryEIP + 8;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodID + 8;
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the EntryEIP field.
                /// </summary>
                public ulong EntryEIP => BitConverter.ToUInt64(_etwEvent.Data[Offset_EntryEIP..]);

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ExceptionFilterStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ExceptionFilterStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_EntryEIP = -1;
                    _offset_MethodID = -1;
                    _offset_MethodName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ExceptionFilterStop event.
        /// </summary>
        public readonly ref struct ExceptionFilterStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionFilterStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 255,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.ExceptionFilter,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            /// Creates a new ExceptionFilterStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionFilterStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a ExceptionStop event.
        /// </summary>
        public readonly ref struct ExceptionStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 256,
                Version = 0,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.Exception,
                Keyword = (ulong)Keywords.ExceptionKeyword
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
            /// Creates a new ExceptionStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }
        }

        /// <summary>
        /// An event wrapper for a GCStop event.
        /// </summary>
        public readonly ref struct GCStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCStop";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCStop event.
            /// </summary>
            public ref struct GCStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_Depth;
                private int _offset_ClrInstanceID;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_Depth
                {
                    get
                    {
                        if (_offset_Depth == -1)
                        {
                            _offset_Depth = Offset_Count + 4;
                        }

                        return _offset_Depth;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Depth + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the Depth field.
                /// </summary>
                public uint Depth => BitConverter.ToUInt32(_etwEvent.Data[Offset_Depth..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_Depth = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCRestartEEStop event.
        /// </summary>
        public readonly ref struct GCRestartEEStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCRestartEEStop";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.RestartEEStop,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCRestartEEStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCRestartEEStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCRestartEEStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCRestartEEStop event.
            /// </summary>
            public ref struct GCRestartEEStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCRestartEEStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCRestartEEStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCHeapStats event.
        /// </summary>
        public readonly ref struct GCHeapStatsEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCHeapStats";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 4,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.HeapStats,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCHeapStatsData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCHeapStatsEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCHeapStatsEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCHeapStats event.
            /// </summary>
            public ref struct GCHeapStatsData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_GenerationSize0;
                private int _offset_TotalPromotedSize0;
                private int _offset_GenerationSize1;
                private int _offset_TotalPromotedSize1;
                private int _offset_GenerationSize2;
                private int _offset_TotalPromotedSize2;
                private int _offset_GenerationSize3;
                private int _offset_TotalPromotedSize3;
                private int _offset_FinalizationPromotedSize;
                private int _offset_FinalizationPromotedCount;
                private int _offset_PinnedObjectCount;
                private int _offset_SinkBlockCount;
                private int _offset_GCHandleCount;
                private int _offset_ClrInstanceID;

                private int Offset_GenerationSize0
                {
                    get
                    {
                        if (_offset_GenerationSize0 == -1)
                        {
                            _offset_GenerationSize0 = 0;
                        }

                        return _offset_GenerationSize0;
                    }
                }

                private int Offset_TotalPromotedSize0
                {
                    get
                    {
                        if (_offset_TotalPromotedSize0 == -1)
                        {
                            _offset_TotalPromotedSize0 = Offset_GenerationSize0 + 8;
                        }

                        return _offset_TotalPromotedSize0;
                    }
                }

                private int Offset_GenerationSize1
                {
                    get
                    {
                        if (_offset_GenerationSize1 == -1)
                        {
                            _offset_GenerationSize1 = Offset_TotalPromotedSize0 + 8;
                        }

                        return _offset_GenerationSize1;
                    }
                }

                private int Offset_TotalPromotedSize1
                {
                    get
                    {
                        if (_offset_TotalPromotedSize1 == -1)
                        {
                            _offset_TotalPromotedSize1 = Offset_GenerationSize1 + 8;
                        }

                        return _offset_TotalPromotedSize1;
                    }
                }

                private int Offset_GenerationSize2
                {
                    get
                    {
                        if (_offset_GenerationSize2 == -1)
                        {
                            _offset_GenerationSize2 = Offset_TotalPromotedSize1 + 8;
                        }

                        return _offset_GenerationSize2;
                    }
                }

                private int Offset_TotalPromotedSize2
                {
                    get
                    {
                        if (_offset_TotalPromotedSize2 == -1)
                        {
                            _offset_TotalPromotedSize2 = Offset_GenerationSize2 + 8;
                        }

                        return _offset_TotalPromotedSize2;
                    }
                }

                private int Offset_GenerationSize3
                {
                    get
                    {
                        if (_offset_GenerationSize3 == -1)
                        {
                            _offset_GenerationSize3 = Offset_TotalPromotedSize2 + 8;
                        }

                        return _offset_GenerationSize3;
                    }
                }

                private int Offset_TotalPromotedSize3
                {
                    get
                    {
                        if (_offset_TotalPromotedSize3 == -1)
                        {
                            _offset_TotalPromotedSize3 = Offset_GenerationSize3 + 8;
                        }

                        return _offset_TotalPromotedSize3;
                    }
                }

                private int Offset_FinalizationPromotedSize
                {
                    get
                    {
                        if (_offset_FinalizationPromotedSize == -1)
                        {
                            _offset_FinalizationPromotedSize = Offset_TotalPromotedSize3 + 8;
                        }

                        return _offset_FinalizationPromotedSize;
                    }
                }

                private int Offset_FinalizationPromotedCount
                {
                    get
                    {
                        if (_offset_FinalizationPromotedCount == -1)
                        {
                            _offset_FinalizationPromotedCount = Offset_FinalizationPromotedSize + 8;
                        }

                        return _offset_FinalizationPromotedCount;
                    }
                }

                private int Offset_PinnedObjectCount
                {
                    get
                    {
                        if (_offset_PinnedObjectCount == -1)
                        {
                            _offset_PinnedObjectCount = Offset_FinalizationPromotedCount + 8;
                        }

                        return _offset_PinnedObjectCount;
                    }
                }

                private int Offset_SinkBlockCount
                {
                    get
                    {
                        if (_offset_SinkBlockCount == -1)
                        {
                            _offset_SinkBlockCount = Offset_PinnedObjectCount + 4;
                        }

                        return _offset_SinkBlockCount;
                    }
                }

                private int Offset_GCHandleCount
                {
                    get
                    {
                        if (_offset_GCHandleCount == -1)
                        {
                            _offset_GCHandleCount = Offset_SinkBlockCount + 4;
                        }

                        return _offset_GCHandleCount;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_GCHandleCount + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the GenerationSize0 field.
                /// </summary>
                public ulong GenerationSize0 => BitConverter.ToUInt64(_etwEvent.Data[Offset_GenerationSize0..]);

                /// <summary>
                /// Retrieves the TotalPromotedSize0 field.
                /// </summary>
                public ulong TotalPromotedSize0 => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalPromotedSize0..]);

                /// <summary>
                /// Retrieves the GenerationSize1 field.
                /// </summary>
                public ulong GenerationSize1 => BitConverter.ToUInt64(_etwEvent.Data[Offset_GenerationSize1..]);

                /// <summary>
                /// Retrieves the TotalPromotedSize1 field.
                /// </summary>
                public ulong TotalPromotedSize1 => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalPromotedSize1..]);

                /// <summary>
                /// Retrieves the GenerationSize2 field.
                /// </summary>
                public ulong GenerationSize2 => BitConverter.ToUInt64(_etwEvent.Data[Offset_GenerationSize2..]);

                /// <summary>
                /// Retrieves the TotalPromotedSize2 field.
                /// </summary>
                public ulong TotalPromotedSize2 => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalPromotedSize2..]);

                /// <summary>
                /// Retrieves the GenerationSize3 field.
                /// </summary>
                public ulong GenerationSize3 => BitConverter.ToUInt64(_etwEvent.Data[Offset_GenerationSize3..]);

                /// <summary>
                /// Retrieves the TotalPromotedSize3 field.
                /// </summary>
                public ulong TotalPromotedSize3 => BitConverter.ToUInt64(_etwEvent.Data[Offset_TotalPromotedSize3..]);

                /// <summary>
                /// Retrieves the FinalizationPromotedSize field.
                /// </summary>
                public ulong FinalizationPromotedSize => BitConverter.ToUInt64(_etwEvent.Data[Offset_FinalizationPromotedSize..]);

                /// <summary>
                /// Retrieves the FinalizationPromotedCount field.
                /// </summary>
                public ulong FinalizationPromotedCount => BitConverter.ToUInt64(_etwEvent.Data[Offset_FinalizationPromotedCount..]);

                /// <summary>
                /// Retrieves the PinnedObjectCount field.
                /// </summary>
                public uint PinnedObjectCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_PinnedObjectCount..]);

                /// <summary>
                /// Retrieves the SinkBlockCount field.
                /// </summary>
                public uint SinkBlockCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_SinkBlockCount..]);

                /// <summary>
                /// Retrieves the GCHandleCount field.
                /// </summary>
                public uint GCHandleCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_GCHandleCount..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCHeapStatsData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCHeapStatsData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_GenerationSize0 = -1;
                    _offset_TotalPromotedSize0 = -1;
                    _offset_GenerationSize1 = -1;
                    _offset_TotalPromotedSize1 = -1;
                    _offset_GenerationSize2 = -1;
                    _offset_TotalPromotedSize2 = -1;
                    _offset_GenerationSize3 = -1;
                    _offset_TotalPromotedSize3 = -1;
                    _offset_FinalizationPromotedSize = -1;
                    _offset_FinalizationPromotedCount = -1;
                    _offset_PinnedObjectCount = -1;
                    _offset_SinkBlockCount = -1;
                    _offset_GCHandleCount = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCCreateSegment event.
        /// </summary>
        public readonly ref struct GCCreateSegmentEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCCreateSegment";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 5,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.CreateSegment,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCCreateSegmentData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCCreateSegmentEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCCreateSegmentEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCCreateSegment event.
            /// </summary>
            public ref struct GCCreateSegmentData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Address;
                private int _offset_Size;
                private int _offset_Type;
                private int _offset_ClrInstanceID;

                private int Offset_Address
                {
                    get
                    {
                        if (_offset_Address == -1)
                        {
                            _offset_Address = 0;
                        }

                        return _offset_Address;
                    }
                }

                private int Offset_Size
                {
                    get
                    {
                        if (_offset_Size == -1)
                        {
                            _offset_Size = Offset_Address + 8;
                        }

                        return _offset_Size;
                    }
                }

                private int Offset_Type
                {
                    get
                    {
                        if (_offset_Type == -1)
                        {
                            _offset_Type = Offset_Size + 8;
                        }

                        return _offset_Type;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Type + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Address field.
                /// </summary>
                public ulong Address => BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

                /// <summary>
                /// Retrieves the Size field.
                /// </summary>
                public ulong Size => BitConverter.ToUInt64(_etwEvent.Data[Offset_Size..]);

                /// <summary>
                /// Retrieves the Type field.
                /// </summary>
                public GCSegmentTypeMap Type => (GCSegmentTypeMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Type..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCCreateSegmentData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCCreateSegmentData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Address = -1;
                    _offset_Size = -1;
                    _offset_Type = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCFreeSegment event.
        /// </summary>
        public readonly ref struct GCFreeSegmentEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCFreeSegment";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 6,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.FreeSegment,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCFreeSegmentData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCFreeSegmentEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCFreeSegmentEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCFreeSegment event.
            /// </summary>
            public ref struct GCFreeSegmentData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Address;
                private int _offset_ClrInstanceID;

                private int Offset_Address
                {
                    get
                    {
                        if (_offset_Address == -1)
                        {
                            _offset_Address = 0;
                        }

                        return _offset_Address;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Address + 8;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Address field.
                /// </summary>
                public ulong Address => BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCFreeSegmentData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCFreeSegmentData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Address = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCRestartEEStart event.
        /// </summary>
        public readonly ref struct GCRestartEEStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCRestartEEStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 7,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.RestartEEStart,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCRestartEEStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCRestartEEStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCRestartEEStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCRestartEEStart event.
            /// </summary>
            public ref struct GCRestartEEStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCRestartEEStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCRestartEEStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCSuspendEEStop event.
        /// </summary>
        public readonly ref struct GCSuspendEEStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCSuspendEEStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 8,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SuspendEEStop,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCSuspendEEStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCSuspendEEStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCSuspendEEStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCSuspendEEStop event.
            /// </summary>
            public ref struct GCSuspendEEStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCSuspendEEStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCSuspendEEStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCSuspendEEStart event.
        /// </summary>
        public readonly ref struct GCSuspendEEStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCSuspendEEStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 9,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SuspendEEStart,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCSuspendEEStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCSuspendEEStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCSuspendEEStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCSuspendEEStart event.
            /// </summary>
            public ref struct GCSuspendEEStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Reason;
                private int _offset_Count;
                private int _offset_ClrInstanceID;

                private int Offset_Reason
                {
                    get
                    {
                        if (_offset_Reason == -1)
                        {
                            _offset_Reason = 0;
                        }

                        return _offset_Reason;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_Reason + 4;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Reason field.
                /// </summary>
                public GCSuspendEEReasonMap Reason => (GCSuspendEEReasonMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Reason..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCSuspendEEStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCSuspendEEStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Reason = -1;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCCreateConcurrentThread event.
        /// </summary>
        public readonly ref struct GCCreateConcurrentThreadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCCreateConcurrentThread";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.CreateConcurrentThread,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword | (ulong)Keywords.ThreadingKeyword
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
            public GCCreateConcurrentThreadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCCreateConcurrentThreadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCCreateConcurrentThreadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCCreateConcurrentThread event.
            /// </summary>
            public ref struct GCCreateConcurrentThreadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCCreateConcurrentThreadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCCreateConcurrentThreadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCTerminateConcurrentThread event.
        /// </summary>
        public readonly ref struct GCTerminateConcurrentThreadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCTerminateConcurrentThread";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.TerminateConcurrentThread,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword | (ulong)Keywords.ThreadingKeyword
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
            public GCTerminateConcurrentThreadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCTerminateConcurrentThreadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCTerminateConcurrentThreadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCTerminateConcurrentThread event.
            /// </summary>
            public ref struct GCTerminateConcurrentThreadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCTerminateConcurrentThreadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCTerminateConcurrentThreadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCFinalizersStop event.
        /// </summary>
        public readonly ref struct GCFinalizersStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCFinalizersStop";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.FinalizersStop,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCFinalizersStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCFinalizersStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCFinalizersStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCFinalizersStop event.
            /// </summary>
            public ref struct GCFinalizersStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_ClrInstanceID;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Count + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCFinalizersStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCFinalizersStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCFinalizersStart event.
        /// </summary>
        public readonly ref struct GCFinalizersStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCFinalizersStart";

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
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.FinalizersStart,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCFinalizersStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCFinalizersStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCFinalizersStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCFinalizersStart event.
            /// </summary>
            public ref struct GCFinalizersStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new GCFinalizersStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCFinalizersStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a IOThreadCreationStart event.
        /// </summary>
        public readonly ref struct IOThreadCreationStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "IOThreadCreationStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 44,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.IOThreadCreation,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public IOThreadCreationStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new IOThreadCreationStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public IOThreadCreationStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a IOThreadCreationStart event.
            /// </summary>
            public ref struct IOThreadCreationStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_IOThreadCount;
                private int _offset_RetiredIOThreads;
                private int _offset_ClrInstanceID;

                private int Offset_IOThreadCount
                {
                    get
                    {
                        if (_offset_IOThreadCount == -1)
                        {
                            _offset_IOThreadCount = 0;
                        }

                        return _offset_IOThreadCount;
                    }
                }

                private int Offset_RetiredIOThreads
                {
                    get
                    {
                        if (_offset_RetiredIOThreads == -1)
                        {
                            _offset_RetiredIOThreads = Offset_IOThreadCount + 4;
                        }

                        return _offset_RetiredIOThreads;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredIOThreads + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the IOThreadCount field.
                /// </summary>
                public uint IOThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_IOThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredIOThreads field.
                /// </summary>
                public uint RetiredIOThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredIOThreads..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new IOThreadCreationStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public IOThreadCreationStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_IOThreadCount = -1;
                    _offset_RetiredIOThreads = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a IOThreadCreationStop event.
        /// </summary>
        public readonly ref struct IOThreadCreationStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "IOThreadCreationStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 45,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.IOThreadCreation,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public IOThreadCreationStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new IOThreadCreationStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public IOThreadCreationStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a IOThreadCreationStop event.
            /// </summary>
            public ref struct IOThreadCreationStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_IOThreadCount;
                private int _offset_RetiredIOThreads;
                private int _offset_ClrInstanceID;

                private int Offset_IOThreadCount
                {
                    get
                    {
                        if (_offset_IOThreadCount == -1)
                        {
                            _offset_IOThreadCount = 0;
                        }

                        return _offset_IOThreadCount;
                    }
                }

                private int Offset_RetiredIOThreads
                {
                    get
                    {
                        if (_offset_RetiredIOThreads == -1)
                        {
                            _offset_RetiredIOThreads = Offset_IOThreadCount + 4;
                        }

                        return _offset_RetiredIOThreads;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredIOThreads + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the IOThreadCount field.
                /// </summary>
                public uint IOThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_IOThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredIOThreads field.
                /// </summary>
                public uint RetiredIOThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredIOThreads..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new IOThreadCreationStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public IOThreadCreationStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_IOThreadCount = -1;
                    _offset_RetiredIOThreads = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a IOThreadRetirementStart event.
        /// </summary>
        public readonly ref struct IOThreadRetirementStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "IOThreadRetirementStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 46,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.IOThreadRetirement,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public IOThreadRetirementStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new IOThreadRetirementStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public IOThreadRetirementStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a IOThreadRetirementStart event.
            /// </summary>
            public ref struct IOThreadRetirementStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_IOThreadCount;
                private int _offset_RetiredIOThreads;
                private int _offset_ClrInstanceID;

                private int Offset_IOThreadCount
                {
                    get
                    {
                        if (_offset_IOThreadCount == -1)
                        {
                            _offset_IOThreadCount = 0;
                        }

                        return _offset_IOThreadCount;
                    }
                }

                private int Offset_RetiredIOThreads
                {
                    get
                    {
                        if (_offset_RetiredIOThreads == -1)
                        {
                            _offset_RetiredIOThreads = Offset_IOThreadCount + 4;
                        }

                        return _offset_RetiredIOThreads;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredIOThreads + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the IOThreadCount field.
                /// </summary>
                public uint IOThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_IOThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredIOThreads field.
                /// </summary>
                public uint RetiredIOThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredIOThreads..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new IOThreadRetirementStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public IOThreadRetirementStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_IOThreadCount = -1;
                    _offset_RetiredIOThreads = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a IOThreadRetirementStop event.
        /// </summary>
        public readonly ref struct IOThreadRetirementStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "IOThreadRetirementStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 47,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.IOThreadRetirement,
                Keyword = (ulong)Keywords.ThreadingKeyword
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
            public IOThreadRetirementStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new IOThreadRetirementStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public IOThreadRetirementStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a IOThreadRetirementStop event.
            /// </summary>
            public ref struct IOThreadRetirementStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_IOThreadCount;
                private int _offset_RetiredIOThreads;
                private int _offset_ClrInstanceID;

                private int Offset_IOThreadCount
                {
                    get
                    {
                        if (_offset_IOThreadCount == -1)
                        {
                            _offset_IOThreadCount = 0;
                        }

                        return _offset_IOThreadCount;
                    }
                }

                private int Offset_RetiredIOThreads
                {
                    get
                    {
                        if (_offset_RetiredIOThreads == -1)
                        {
                            _offset_RetiredIOThreads = Offset_IOThreadCount + 4;
                        }

                        return _offset_RetiredIOThreads;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_RetiredIOThreads + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the IOThreadCount field.
                /// </summary>
                public uint IOThreadCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_IOThreadCount..]);

                /// <summary>
                /// Retrieves the RetiredIOThreads field.
                /// </summary>
                public uint RetiredIOThreads => BitConverter.ToUInt32(_etwEvent.Data[Offset_RetiredIOThreads..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new IOThreadRetirementStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public IOThreadRetirementStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_IOThreadCount = -1;
                    _offset_RetiredIOThreads = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ExceptionStart event.
        /// </summary>
        public readonly ref struct ExceptionStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ExceptionStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 80,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Error,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.Exception,
                Keyword = (ulong)Keywords.ExceptionKeyword | (ulong)Keywords.MonitoringKeyword
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
            public ExceptionStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ExceptionStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ExceptionStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ExceptionStart event.
            /// </summary>
            public ref struct ExceptionStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ExceptionType;
                private int _offset_ExceptionMessage;
                private int _offset_ExceptionEIP;
                private int _offset_ExceptionHRESULT;
                private int _offset_ExceptionFlags;
                private int _offset_ClrInstanceID;

                private int Offset_ExceptionType
                {
                    get
                    {
                        if (_offset_ExceptionType == -1)
                        {
                            _offset_ExceptionType = 0;
                        }

                        return _offset_ExceptionType;
                    }
                }

                private int Offset_ExceptionMessage
                {
                    get
                    {
                        if (_offset_ExceptionMessage == -1)
                        {
                            _offset_ExceptionMessage = Offset_ExceptionType + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ExceptionType);
                        }

                        return _offset_ExceptionMessage;
                    }
                }

                private int Offset_ExceptionEIP
                {
                    get
                    {
                        if (_offset_ExceptionEIP == -1)
                        {
                            _offset_ExceptionEIP = Offset_ExceptionMessage + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ExceptionMessage);
                        }

                        return _offset_ExceptionEIP;
                    }
                }

                private int Offset_ExceptionHRESULT
                {
                    get
                    {
                        if (_offset_ExceptionHRESULT == -1)
                        {
                            _offset_ExceptionHRESULT = Offset_ExceptionEIP + _etwEvent.AddressSize;
                        }

                        return _offset_ExceptionHRESULT;
                    }
                }

                private int Offset_ExceptionFlags
                {
                    get
                    {
                        if (_offset_ExceptionFlags == -1)
                        {
                            _offset_ExceptionFlags = Offset_ExceptionHRESULT + 4;
                        }

                        return _offset_ExceptionFlags;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ExceptionFlags + 2;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ExceptionType field.
                /// </summary>
                public string ExceptionType => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ExceptionType..]);

                /// <summary>
                /// Retrieves the ExceptionMessage field.
                /// </summary>
                public string ExceptionMessage => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ExceptionMessage..]);

                /// <summary>
                /// Retrieves the ExceptionEIP field.
                /// </summary>
                public ulong ExceptionEIP => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ExceptionEIP..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ExceptionEIP..]);

                /// <summary>
                /// Retrieves the ExceptionHRESULT field.
                /// </summary>
                public uint ExceptionHRESULT => BitConverter.ToUInt32(_etwEvent.Data[Offset_ExceptionHRESULT..]);

                /// <summary>
                /// Retrieves the ExceptionFlags field.
                /// </summary>
                public ExceptionThrownFlagsMap ExceptionFlags => (ExceptionThrownFlagsMap)BitConverter.ToUInt16(_etwEvent.Data[Offset_ExceptionFlags..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ExceptionStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ExceptionStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ExceptionType = -1;
                    _offset_ExceptionMessage = -1;
                    _offset_ExceptionEIP = -1;
                    _offset_ExceptionHRESULT = -1;
                    _offset_ExceptionFlags = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a ContentionStart event.
        /// </summary>
        public readonly ref struct ContentionStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "ContentionStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 81,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.Contention,
                Keyword = (ulong)Keywords.ContentionKeyword
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
            public ContentionStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new ContentionStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public ContentionStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a ContentionStart event.
            /// </summary>
            public ref struct ContentionStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ContentionFlags;
                private int _offset_ClrInstanceID;

                private int Offset_ContentionFlags
                {
                    get
                    {
                        if (_offset_ContentionFlags == -1)
                        {
                            _offset_ContentionFlags = 0;
                        }

                        return _offset_ContentionFlags;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ContentionFlags + 1;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ContentionFlags field.
                /// </summary>
                public ContentionFlagsMap ContentionFlags => (ContentionFlagsMap)_etwEvent.Data[Offset_ContentionFlags];

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new ContentionStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public ContentionStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ContentionFlags = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodJittingStarted event.
        /// </summary>
        public readonly ref struct MethodJittingStartedEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodJittingStarted";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 145,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.JittingStarted,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword
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
            public MethodJittingStartedData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodJittingStartedEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodJittingStartedEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodJittingStarted event.
            /// </summary>
            public ref struct MethodJittingStartedData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodToken;
                private int _offset_MethodILSize;
                private int _offset_MethodNamespace;
                private int _offset_MethodName;
                private int _offset_MethodSignature;
                private int _offset_ClrInstanceID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_ModuleID + 8;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodILSize
                {
                    get
                    {
                        if (_offset_MethodILSize == -1)
                        {
                            _offset_MethodILSize = Offset_MethodToken + 4;
                        }

                        return _offset_MethodILSize;
                    }
                }

                private int Offset_MethodNamespace
                {
                    get
                    {
                        if (_offset_MethodNamespace == -1)
                        {
                            _offset_MethodNamespace = Offset_MethodILSize + 4;
                        }

                        return _offset_MethodNamespace;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodNamespace);
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_MethodSignature
                {
                    get
                    {
                        if (_offset_MethodSignature == -1)
                        {
                            _offset_MethodSignature = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_MethodSignature;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodSignature);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodILSize field.
                /// </summary>
                public uint MethodILSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodILSize..]);

                /// <summary>
                /// Retrieves the MethodNamespace field.
                /// </summary>
                public string MethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodNamespace..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the MethodSignature field.
                /// </summary>
                public string MethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodSignature..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new MethodJittingStartedData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodJittingStartedData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodILSize = -1;
                    _offset_MethodNamespace = -1;
                    _offset_MethodName = -1;
                    _offset_MethodSignature = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderDomainModuleLoad event.
        /// </summary>
        public readonly ref struct LoaderDomainModuleLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderDomainModuleLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 151,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.DomainModuleLoad,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderDomainModuleLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderDomainModuleLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderDomainModuleLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderDomainModuleLoad event.
            /// </summary>
            public ref struct LoaderDomainModuleLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ModuleID;
                private int _offset_AssemblyID;
                private int _offset_AppDomainID;
                private int _offset_ModuleFlags;
                private int _offset_Reserved1;
                private int _offset_ModuleILPath;
                private int _offset_ModuleNativePath;
                private int _offset_ClrInstanceID;

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = 0;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = Offset_ModuleID + 8;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_AssemblyID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_ModuleFlags
                {
                    get
                    {
                        if (_offset_ModuleFlags == -1)
                        {
                            _offset_ModuleFlags = Offset_AppDomainID + 8;
                        }

                        return _offset_ModuleFlags;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ModuleFlags + 4;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_ModuleILPath
                {
                    get
                    {
                        if (_offset_ModuleILPath == -1)
                        {
                            _offset_ModuleILPath = Offset_Reserved1 + 4;
                        }

                        return _offset_ModuleILPath;
                    }
                }

                private int Offset_ModuleNativePath
                {
                    get
                    {
                        if (_offset_ModuleNativePath == -1)
                        {
                            _offset_ModuleNativePath = Offset_ModuleILPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleILPath);
                        }

                        return _offset_ModuleNativePath;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ModuleNativePath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleNativePath);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the ModuleFlags field.
                /// </summary>
                public ModuleFlagsMap ModuleFlags => (ModuleFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_ModuleFlags..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public uint Reserved1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reserved1..]);

                /// <summary>
                /// Retrieves the ModuleILPath field.
                /// </summary>
                public string ModuleILPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleILPath..]);

                /// <summary>
                /// Retrieves the ModuleNativePath field.
                /// </summary>
                public string ModuleNativePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleNativePath..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new LoaderDomainModuleLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderDomainModuleLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ModuleID = -1;
                    _offset_AssemblyID = -1;
                    _offset_AppDomainID = -1;
                    _offset_ModuleFlags = -1;
                    _offset_Reserved1 = -1;
                    _offset_ModuleILPath = -1;
                    _offset_ModuleNativePath = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderAssemblyLoad event.
        /// </summary>
        public readonly ref struct LoaderAssemblyLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderAssemblyLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 154,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.LoadVerbose,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderAssemblyLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderAssemblyLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderAssemblyLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderAssemblyLoad event.
            /// </summary>
            public ref struct LoaderAssemblyLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AssemblyID;
                private int _offset_AppDomainID;
                private int _offset_BindingID;
                private int _offset_AssemblyFlags;
                private int _offset_FullyQualifiedAssemblyName;
                private int _offset_ClrInstanceID;

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = 0;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_AssemblyID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_BindingID
                {
                    get
                    {
                        if (_offset_BindingID == -1)
                        {
                            _offset_BindingID = Offset_AppDomainID + 8;
                        }

                        return _offset_BindingID;
                    }
                }

                private int Offset_AssemblyFlags
                {
                    get
                    {
                        if (_offset_AssemblyFlags == -1)
                        {
                            _offset_AssemblyFlags = Offset_BindingID + 8;
                        }

                        return _offset_AssemblyFlags;
                    }
                }

                private int Offset_FullyQualifiedAssemblyName
                {
                    get
                    {
                        if (_offset_FullyQualifiedAssemblyName == -1)
                        {
                            _offset_FullyQualifiedAssemblyName = Offset_AssemblyFlags + 4;
                        }

                        return _offset_FullyQualifiedAssemblyName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FullyQualifiedAssemblyName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_FullyQualifiedAssemblyName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the BindingID field.
                /// </summary>
                public ulong BindingID => BitConverter.ToUInt64(_etwEvent.Data[Offset_BindingID..]);

                /// <summary>
                /// Retrieves the AssemblyFlags field.
                /// </summary>
                public AssemblyFlagsMap AssemblyFlags => (AssemblyFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_AssemblyFlags..]);

                /// <summary>
                /// Retrieves the FullyQualifiedAssemblyName field.
                /// </summary>
                public string FullyQualifiedAssemblyName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_FullyQualifiedAssemblyName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new LoaderAssemblyLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderAssemblyLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AssemblyID = -1;
                    _offset_AppDomainID = -1;
                    _offset_BindingID = -1;
                    _offset_AssemblyFlags = -1;
                    _offset_FullyQualifiedAssemblyName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderAssemblyUnload event.
        /// </summary>
        public readonly ref struct LoaderAssemblyUnloadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderAssemblyUnload";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 155,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootCCW,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderAssemblyUnloadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderAssemblyUnloadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderAssemblyUnloadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderAssemblyUnload event.
            /// </summary>
            public ref struct LoaderAssemblyUnloadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AssemblyID;
                private int _offset_AppDomainID;
                private int _offset_BindingID;
                private int _offset_AssemblyFlags;
                private int _offset_FullyQualifiedAssemblyName;
                private int _offset_ClrInstanceID;

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = 0;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = Offset_AssemblyID + 8;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_BindingID
                {
                    get
                    {
                        if (_offset_BindingID == -1)
                        {
                            _offset_BindingID = Offset_AppDomainID + 8;
                        }

                        return _offset_BindingID;
                    }
                }

                private int Offset_AssemblyFlags
                {
                    get
                    {
                        if (_offset_AssemblyFlags == -1)
                        {
                            _offset_AssemblyFlags = Offset_BindingID + 8;
                        }

                        return _offset_AssemblyFlags;
                    }
                }

                private int Offset_FullyQualifiedAssemblyName
                {
                    get
                    {
                        if (_offset_FullyQualifiedAssemblyName == -1)
                        {
                            _offset_FullyQualifiedAssemblyName = Offset_AssemblyFlags + 4;
                        }

                        return _offset_FullyQualifiedAssemblyName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FullyQualifiedAssemblyName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_FullyQualifiedAssemblyName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the BindingID field.
                /// </summary>
                public ulong BindingID => BitConverter.ToUInt64(_etwEvent.Data[Offset_BindingID..]);

                /// <summary>
                /// Retrieves the AssemblyFlags field.
                /// </summary>
                public AssemblyFlagsMap AssemblyFlags => (AssemblyFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_AssemblyFlags..]);

                /// <summary>
                /// Retrieves the FullyQualifiedAssemblyName field.
                /// </summary>
                public string FullyQualifiedAssemblyName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_FullyQualifiedAssemblyName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new LoaderAssemblyUnloadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderAssemblyUnloadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AssemblyID = -1;
                    _offset_AppDomainID = -1;
                    _offset_BindingID = -1;
                    _offset_AssemblyFlags = -1;
                    _offset_FullyQualifiedAssemblyName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderAppDomainLoad event.
        /// </summary>
        public readonly ref struct LoaderAppDomainLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderAppDomainLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 156,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCDynamicEvent,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderAppDomainLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderAppDomainLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderAppDomainLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderAppDomainLoad event.
            /// </summary>
            public ref struct LoaderAppDomainLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AppDomainID;
                private int _offset_AppDomainFlags;
                private int _offset_AppDomainName;
                private int _offset_AppDomainIndex;
                private int _offset_ClrInstanceID;

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = 0;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_AppDomainFlags
                {
                    get
                    {
                        if (_offset_AppDomainFlags == -1)
                        {
                            _offset_AppDomainFlags = Offset_AppDomainID + 8;
                        }

                        return _offset_AppDomainFlags;
                    }
                }

                private int Offset_AppDomainName
                {
                    get
                    {
                        if (_offset_AppDomainName == -1)
                        {
                            _offset_AppDomainName = Offset_AppDomainFlags + 4;
                        }

                        return _offset_AppDomainName;
                    }
                }

                private int Offset_AppDomainIndex
                {
                    get
                    {
                        if (_offset_AppDomainIndex == -1)
                        {
                            _offset_AppDomainIndex = Offset_AppDomainName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_AppDomainName);
                        }

                        return _offset_AppDomainIndex;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainIndex + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the AppDomainFlags field.
                /// </summary>
                public AppDomainFlagsMap AppDomainFlags => (AppDomainFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_AppDomainFlags..]);

                /// <summary>
                /// Retrieves the AppDomainName field.
                /// </summary>
                public string AppDomainName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_AppDomainName..]);

                /// <summary>
                /// Retrieves the AppDomainIndex field.
                /// </summary>
                public uint AppDomainIndex => BitConverter.ToUInt32(_etwEvent.Data[Offset_AppDomainIndex..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new LoaderAppDomainLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderAppDomainLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AppDomainID = -1;
                    _offset_AppDomainFlags = -1;
                    _offset_AppDomainName = -1;
                    _offset_AppDomainIndex = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderAppDomainUnload event.
        /// </summary>
        public readonly ref struct LoaderAppDomainUnloadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderAppDomainUnload";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 157,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.JittingStarted,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword
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
            public LoaderAppDomainUnloadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderAppDomainUnloadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderAppDomainUnloadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderAppDomainUnload event.
            /// </summary>
            public ref struct LoaderAppDomainUnloadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AppDomainID;
                private int _offset_AppDomainFlags;
                private int _offset_AppDomainName;
                private int _offset_AppDomainIndex;
                private int _offset_ClrInstanceID;

                private int Offset_AppDomainID
                {
                    get
                    {
                        if (_offset_AppDomainID == -1)
                        {
                            _offset_AppDomainID = 0;
                        }

                        return _offset_AppDomainID;
                    }
                }

                private int Offset_AppDomainFlags
                {
                    get
                    {
                        if (_offset_AppDomainFlags == -1)
                        {
                            _offset_AppDomainFlags = Offset_AppDomainID + 8;
                        }

                        return _offset_AppDomainFlags;
                    }
                }

                private int Offset_AppDomainName
                {
                    get
                    {
                        if (_offset_AppDomainName == -1)
                        {
                            _offset_AppDomainName = Offset_AppDomainFlags + 4;
                        }

                        return _offset_AppDomainName;
                    }
                }

                private int Offset_AppDomainIndex
                {
                    get
                    {
                        if (_offset_AppDomainIndex == -1)
                        {
                            _offset_AppDomainIndex = Offset_AppDomainName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_AppDomainName);
                        }

                        return _offset_AppDomainIndex;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AppDomainIndex + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the AppDomainID field.
                /// </summary>
                public ulong AppDomainID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AppDomainID..]);

                /// <summary>
                /// Retrieves the AppDomainFlags field.
                /// </summary>
                public AppDomainFlagsMap AppDomainFlags => (AppDomainFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_AppDomainFlags..]);

                /// <summary>
                /// Retrieves the AppDomainName field.
                /// </summary>
                public string AppDomainName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_AppDomainName..]);

                /// <summary>
                /// Retrieves the AppDomainIndex field.
                /// </summary>
                public uint AppDomainIndex => BitConverter.ToUInt32(_etwEvent.Data[Offset_AppDomainIndex..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new LoaderAppDomainUnloadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderAppDomainUnloadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AppDomainID = -1;
                    _offset_AppDomainFlags = -1;
                    _offset_AppDomainName = -1;
                    _offset_AppDomainIndex = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a StrongNameVerificationStart event.
        /// </summary>
        public readonly ref struct StrongNameVerificationStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "StrongNameVerificationStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 181,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.StrongNameVerification,
                Keyword = (ulong)Keywords.SecurityKeyword
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
            public StrongNameVerificationStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new StrongNameVerificationStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public StrongNameVerificationStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a StrongNameVerificationStart event.
            /// </summary>
            public ref struct StrongNameVerificationStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_VerificationFlags;
                private int _offset_ErrorCode;
                private int _offset_FullyQualifiedAssemblyName;
                private int _offset_ClrInstanceID;

                private int Offset_VerificationFlags
                {
                    get
                    {
                        if (_offset_VerificationFlags == -1)
                        {
                            _offset_VerificationFlags = 0;
                        }

                        return _offset_VerificationFlags;
                    }
                }

                private int Offset_ErrorCode
                {
                    get
                    {
                        if (_offset_ErrorCode == -1)
                        {
                            _offset_ErrorCode = Offset_VerificationFlags + 4;
                        }

                        return _offset_ErrorCode;
                    }
                }

                private int Offset_FullyQualifiedAssemblyName
                {
                    get
                    {
                        if (_offset_FullyQualifiedAssemblyName == -1)
                        {
                            _offset_FullyQualifiedAssemblyName = Offset_ErrorCode + 4;
                        }

                        return _offset_FullyQualifiedAssemblyName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FullyQualifiedAssemblyName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_FullyQualifiedAssemblyName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the VerificationFlags field.
                /// </summary>
                public uint VerificationFlags => BitConverter.ToUInt32(_etwEvent.Data[Offset_VerificationFlags..]);

                /// <summary>
                /// Retrieves the ErrorCode field.
                /// </summary>
                public uint ErrorCode => BitConverter.ToUInt32(_etwEvent.Data[Offset_ErrorCode..]);

                /// <summary>
                /// Retrieves the FullyQualifiedAssemblyName field.
                /// </summary>
                public string FullyQualifiedAssemblyName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_FullyQualifiedAssemblyName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new StrongNameVerificationStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public StrongNameVerificationStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_VerificationFlags = -1;
                    _offset_ErrorCode = -1;
                    _offset_FullyQualifiedAssemblyName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a StrongNameVerificationStop event.
        /// </summary>
        public readonly ref struct StrongNameVerificationStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "StrongNameVerificationStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 182,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.StrongNameVerification,
                Keyword = (ulong)Keywords.SecurityKeyword
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
            public StrongNameVerificationStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new StrongNameVerificationStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public StrongNameVerificationStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a StrongNameVerificationStop event.
            /// </summary>
            public ref struct StrongNameVerificationStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_VerificationFlags;
                private int _offset_ErrorCode;
                private int _offset_FullyQualifiedAssemblyName;
                private int _offset_ClrInstanceID;

                private int Offset_VerificationFlags
                {
                    get
                    {
                        if (_offset_VerificationFlags == -1)
                        {
                            _offset_VerificationFlags = 0;
                        }

                        return _offset_VerificationFlags;
                    }
                }

                private int Offset_ErrorCode
                {
                    get
                    {
                        if (_offset_ErrorCode == -1)
                        {
                            _offset_ErrorCode = Offset_VerificationFlags + 4;
                        }

                        return _offset_ErrorCode;
                    }
                }

                private int Offset_FullyQualifiedAssemblyName
                {
                    get
                    {
                        if (_offset_FullyQualifiedAssemblyName == -1)
                        {
                            _offset_FullyQualifiedAssemblyName = Offset_ErrorCode + 4;
                        }

                        return _offset_FullyQualifiedAssemblyName;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_FullyQualifiedAssemblyName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_FullyQualifiedAssemblyName);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the VerificationFlags field.
                /// </summary>
                public uint VerificationFlags => BitConverter.ToUInt32(_etwEvent.Data[Offset_VerificationFlags..]);

                /// <summary>
                /// Retrieves the ErrorCode field.
                /// </summary>
                public uint ErrorCode => BitConverter.ToUInt32(_etwEvent.Data[Offset_ErrorCode..]);

                /// <summary>
                /// Retrieves the FullyQualifiedAssemblyName field.
                /// </summary>
                public string FullyQualifiedAssemblyName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_FullyQualifiedAssemblyName..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new StrongNameVerificationStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public StrongNameVerificationStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_VerificationFlags = -1;
                    _offset_ErrorCode = -1;
                    _offset_FullyQualifiedAssemblyName = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AuthenticodeVerificationStart event.
        /// </summary>
        public readonly ref struct AuthenticodeVerificationStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AuthenticodeVerificationStart";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 183,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.AuthenticodeVerification,
                Keyword = (ulong)Keywords.SecurityKeyword
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
            public AuthenticodeVerificationStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AuthenticodeVerificationStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AuthenticodeVerificationStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AuthenticodeVerificationStart event.
            /// </summary>
            public ref struct AuthenticodeVerificationStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_VerificationFlags;
                private int _offset_ErrorCode;
                private int _offset_ModulePath;
                private int _offset_ClrInstanceID;

                private int Offset_VerificationFlags
                {
                    get
                    {
                        if (_offset_VerificationFlags == -1)
                        {
                            _offset_VerificationFlags = 0;
                        }

                        return _offset_VerificationFlags;
                    }
                }

                private int Offset_ErrorCode
                {
                    get
                    {
                        if (_offset_ErrorCode == -1)
                        {
                            _offset_ErrorCode = Offset_VerificationFlags + 4;
                        }

                        return _offset_ErrorCode;
                    }
                }

                private int Offset_ModulePath
                {
                    get
                    {
                        if (_offset_ModulePath == -1)
                        {
                            _offset_ModulePath = Offset_ErrorCode + 4;
                        }

                        return _offset_ModulePath;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ModulePath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModulePath);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the VerificationFlags field.
                /// </summary>
                public uint VerificationFlags => BitConverter.ToUInt32(_etwEvent.Data[Offset_VerificationFlags..]);

                /// <summary>
                /// Retrieves the ErrorCode field.
                /// </summary>
                public uint ErrorCode => BitConverter.ToUInt32(_etwEvent.Data[Offset_ErrorCode..]);

                /// <summary>
                /// Retrieves the ModulePath field.
                /// </summary>
                public string ModulePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModulePath..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AuthenticodeVerificationStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AuthenticodeVerificationStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_VerificationFlags = -1;
                    _offset_ErrorCode = -1;
                    _offset_ModulePath = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a AuthenticodeVerificationStop event.
        /// </summary>
        public readonly ref struct AuthenticodeVerificationStopEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "AuthenticodeVerificationStop";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 184,
                Version = 1,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.End,
                Task = (ushort)Tasks.AuthenticodeVerification,
                Keyword = (ulong)Keywords.SecurityKeyword
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
            public AuthenticodeVerificationStopData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new AuthenticodeVerificationStopEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public AuthenticodeVerificationStopEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a AuthenticodeVerificationStop event.
            /// </summary>
            public ref struct AuthenticodeVerificationStopData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_VerificationFlags;
                private int _offset_ErrorCode;
                private int _offset_ModulePath;
                private int _offset_ClrInstanceID;

                private int Offset_VerificationFlags
                {
                    get
                    {
                        if (_offset_VerificationFlags == -1)
                        {
                            _offset_VerificationFlags = 0;
                        }

                        return _offset_VerificationFlags;
                    }
                }

                private int Offset_ErrorCode
                {
                    get
                    {
                        if (_offset_ErrorCode == -1)
                        {
                            _offset_ErrorCode = Offset_VerificationFlags + 4;
                        }

                        return _offset_ErrorCode;
                    }
                }

                private int Offset_ModulePath
                {
                    get
                    {
                        if (_offset_ModulePath == -1)
                        {
                            _offset_ModulePath = Offset_ErrorCode + 4;
                        }

                        return _offset_ModulePath;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ModulePath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModulePath);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                /// <summary>
                /// Retrieves the VerificationFlags field.
                /// </summary>
                public uint VerificationFlags => BitConverter.ToUInt32(_etwEvent.Data[Offset_VerificationFlags..]);

                /// <summary>
                /// Retrieves the ErrorCode field.
                /// </summary>
                public uint ErrorCode => BitConverter.ToUInt32(_etwEvent.Data[Offset_ErrorCode..]);

                /// <summary>
                /// Retrieves the ModulePath field.
                /// </summary>
                public string ModulePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModulePath..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Creates a new AuthenticodeVerificationStopData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public AuthenticodeVerificationStopData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_VerificationFlags = -1;
                    _offset_ErrorCode = -1;
                    _offset_ModulePath = -1;
                    _offset_ClrInstanceID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCStart event.
        /// </summary>
        public readonly ref struct GCStartEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCStart";

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
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = EtwEventOpcode.Start,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCStartData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCStartEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCStartEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCStart event.
            /// </summary>
            public ref struct GCStartData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Count;
                private int _offset_Depth;
                private int _offset_Reason;
                private int _offset_Type;
                private int _offset_ClrInstanceID;
                private int _offset_ClientSequenceNumber;

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = 0;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_Depth
                {
                    get
                    {
                        if (_offset_Depth == -1)
                        {
                            _offset_Depth = Offset_Count + 4;
                        }

                        return _offset_Depth;
                    }
                }

                private int Offset_Reason
                {
                    get
                    {
                        if (_offset_Reason == -1)
                        {
                            _offset_Reason = Offset_Depth + 4;
                        }

                        return _offset_Reason;
                    }
                }

                private int Offset_Type
                {
                    get
                    {
                        if (_offset_Type == -1)
                        {
                            _offset_Type = Offset_Reason + 4;
                        }

                        return _offset_Type;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_Type + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ClientSequenceNumber
                {
                    get
                    {
                        if (_offset_ClientSequenceNumber == -1)
                        {
                            _offset_ClientSequenceNumber = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ClientSequenceNumber;
                    }
                }

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the Depth field.
                /// </summary>
                public uint Depth => BitConverter.ToUInt32(_etwEvent.Data[Offset_Depth..]);

                /// <summary>
                /// Retrieves the Reason field.
                /// </summary>
                public GCReasonMap Reason => (GCReasonMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Reason..]);

                /// <summary>
                /// Retrieves the Type field.
                /// </summary>
                public GCTypeMap Type => (GCTypeMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Type..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ClientSequenceNumber field.
                /// </summary>
                public ulong ClientSequenceNumber => BitConverter.ToUInt64(_etwEvent.Data[Offset_ClientSequenceNumber..]);

                /// <summary>
                /// Creates a new GCStartData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCStartData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Count = -1;
                    _offset_Depth = -1;
                    _offset_Reason = -1;
                    _offset_Type = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ClientSequenceNumber = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodLoad event.
        /// </summary>
        public readonly ref struct MethodLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 141,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SetGCHandle,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodLoad event.
            /// </summary>
            public ref struct MethodLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_ClrInstanceID;
                private int _offset_ReJITID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodFlags + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ReJITID
                {
                    get
                    {
                        if (_offset_ReJITID == -1)
                        {
                            _offset_ReJITID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ReJITID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ReJITID field.
                /// </summary>
                public ulong ReJITID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ReJITID..]);

                /// <summary>
                /// Creates a new MethodLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ReJITID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodUnload event.
        /// </summary>
        public readonly ref struct MethodUnloadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodUnload";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 142,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.DestoryGCHandle,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodUnloadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodUnloadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodUnloadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodUnload event.
            /// </summary>
            public ref struct MethodUnloadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_ClrInstanceID;
                private int _offset_ReJITID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodFlags + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ReJITID
                {
                    get
                    {
                        if (_offset_ReJITID == -1)
                        {
                            _offset_ReJITID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ReJITID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ReJITID field.
                /// </summary>
                public ulong ReJITID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ReJITID..]);

                /// <summary>
                /// Creates a new MethodUnloadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodUnloadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ReJITID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodLoadVerbose event.
        /// </summary>
        public readonly ref struct MethodLoadVerboseEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodLoadVerbose";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 143,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.LoadVerbose,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodLoadVerboseData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodLoadVerboseEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodLoadVerboseEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodLoadVerbose event.
            /// </summary>
            public ref struct MethodLoadVerboseData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_MethodNamespace;
                private int _offset_MethodName;
                private int _offset_MethodSignature;
                private int _offset_ClrInstanceID;
                private int _offset_ReJITID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_MethodNamespace
                {
                    get
                    {
                        if (_offset_MethodNamespace == -1)
                        {
                            _offset_MethodNamespace = Offset_MethodFlags + 4;
                        }

                        return _offset_MethodNamespace;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodNamespace);
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_MethodSignature
                {
                    get
                    {
                        if (_offset_MethodSignature == -1)
                        {
                            _offset_MethodSignature = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_MethodSignature;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodSignature);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ReJITID
                {
                    get
                    {
                        if (_offset_ReJITID == -1)
                        {
                            _offset_ReJITID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ReJITID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the MethodNamespace field.
                /// </summary>
                public string MethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodNamespace..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the MethodSignature field.
                /// </summary>
                public string MethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodSignature..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ReJITID field.
                /// </summary>
                public ulong ReJITID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ReJITID..]);

                /// <summary>
                /// Creates a new MethodLoadVerboseData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodLoadVerboseData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_MethodNamespace = -1;
                    _offset_MethodName = -1;
                    _offset_MethodSignature = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ReJITID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a MethodUnloadVerbose event.
        /// </summary>
        public readonly ref struct MethodUnloadVerboseEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "MethodUnloadVerbose";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 144,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GCBulkRootCCW,
                Task = (ushort)Tasks.Method,
                Keyword = (ulong)Keywords.JitKeyword | (ulong)Keywords.NGenKeyword
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
            public MethodUnloadVerboseData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new MethodUnloadVerboseEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public MethodUnloadVerboseEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a MethodUnloadVerbose event.
            /// </summary>
            public ref struct MethodUnloadVerboseData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_MethodID;
                private int _offset_ModuleID;
                private int _offset_MethodStartAddress;
                private int _offset_MethodSize;
                private int _offset_MethodToken;
                private int _offset_MethodFlags;
                private int _offset_MethodNamespace;
                private int _offset_MethodName;
                private int _offset_MethodSignature;
                private int _offset_ClrInstanceID;
                private int _offset_ReJITID;

                private int Offset_MethodID
                {
                    get
                    {
                        if (_offset_MethodID == -1)
                        {
                            _offset_MethodID = 0;
                        }

                        return _offset_MethodID;
                    }
                }

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = Offset_MethodID + 8;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_MethodStartAddress
                {
                    get
                    {
                        if (_offset_MethodStartAddress == -1)
                        {
                            _offset_MethodStartAddress = Offset_ModuleID + 8;
                        }

                        return _offset_MethodStartAddress;
                    }
                }

                private int Offset_MethodSize
                {
                    get
                    {
                        if (_offset_MethodSize == -1)
                        {
                            _offset_MethodSize = Offset_MethodStartAddress + 8;
                        }

                        return _offset_MethodSize;
                    }
                }

                private int Offset_MethodToken
                {
                    get
                    {
                        if (_offset_MethodToken == -1)
                        {
                            _offset_MethodToken = Offset_MethodSize + 4;
                        }

                        return _offset_MethodToken;
                    }
                }

                private int Offset_MethodFlags
                {
                    get
                    {
                        if (_offset_MethodFlags == -1)
                        {
                            _offset_MethodFlags = Offset_MethodToken + 4;
                        }

                        return _offset_MethodFlags;
                    }
                }

                private int Offset_MethodNamespace
                {
                    get
                    {
                        if (_offset_MethodNamespace == -1)
                        {
                            _offset_MethodNamespace = Offset_MethodFlags + 4;
                        }

                        return _offset_MethodNamespace;
                    }
                }

                private int Offset_MethodName
                {
                    get
                    {
                        if (_offset_MethodName == -1)
                        {
                            _offset_MethodName = Offset_MethodNamespace + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodNamespace);
                        }

                        return _offset_MethodName;
                    }
                }

                private int Offset_MethodSignature
                {
                    get
                    {
                        if (_offset_MethodSignature == -1)
                        {
                            _offset_MethodSignature = Offset_MethodName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodName);
                        }

                        return _offset_MethodSignature;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_MethodSignature + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_MethodSignature);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ReJITID
                {
                    get
                    {
                        if (_offset_ReJITID == -1)
                        {
                            _offset_ReJITID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ReJITID;
                    }
                }

                /// <summary>
                /// Retrieves the MethodID field.
                /// </summary>
                public ulong MethodID => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodID..]);

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the MethodStartAddress field.
                /// </summary>
                public ulong MethodStartAddress => BitConverter.ToUInt64(_etwEvent.Data[Offset_MethodStartAddress..]);

                /// <summary>
                /// Retrieves the MethodSize field.
                /// </summary>
                public uint MethodSize => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodSize..]);

                /// <summary>
                /// Retrieves the MethodToken field.
                /// </summary>
                public uint MethodToken => BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodToken..]);

                /// <summary>
                /// Retrieves the MethodFlags field.
                /// </summary>
                public MethodFlagsMap MethodFlags => (MethodFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_MethodFlags..]);

                /// <summary>
                /// Retrieves the MethodNamespace field.
                /// </summary>
                public string MethodNamespace => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodNamespace..]);

                /// <summary>
                /// Retrieves the MethodName field.
                /// </summary>
                public string MethodName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodName..]);

                /// <summary>
                /// Retrieves the MethodSignature field.
                /// </summary>
                public string MethodSignature => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_MethodSignature..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ReJITID field.
                /// </summary>
                public ulong ReJITID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ReJITID..]);

                /// <summary>
                /// Creates a new MethodUnloadVerboseData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public MethodUnloadVerboseData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_MethodID = -1;
                    _offset_ModuleID = -1;
                    _offset_MethodStartAddress = -1;
                    _offset_MethodSize = -1;
                    _offset_MethodToken = -1;
                    _offset_MethodFlags = -1;
                    _offset_MethodNamespace = -1;
                    _offset_MethodName = -1;
                    _offset_MethodSignature = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ReJITID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderModuleLoad event.
        /// </summary>
        public readonly ref struct LoaderModuleLoadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderModuleLoad";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 152,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.SetGCHandle,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword | (ulong)Keywords.PerfTrackKeyword
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
            public LoaderModuleLoadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderModuleLoadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderModuleLoadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderModuleLoad event.
            /// </summary>
            public ref struct LoaderModuleLoadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ModuleID;
                private int _offset_AssemblyID;
                private int _offset_ModuleFlags;
                private int _offset_Reserved1;
                private int _offset_ModuleILPath;
                private int _offset_ModuleNativePath;
                private int _offset_ClrInstanceID;
                private int _offset_ManagedPdbSignature;
                private int _offset_ManagedPdbAge;
                private int _offset_ManagedPdbBuildPath;
                private int _offset_NativePdbSignature;
                private int _offset_NativePdbAge;
                private int _offset_NativePdbBuildPath;

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = 0;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = Offset_ModuleID + 8;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_ModuleFlags
                {
                    get
                    {
                        if (_offset_ModuleFlags == -1)
                        {
                            _offset_ModuleFlags = Offset_AssemblyID + 8;
                        }

                        return _offset_ModuleFlags;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ModuleFlags + 4;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_ModuleILPath
                {
                    get
                    {
                        if (_offset_ModuleILPath == -1)
                        {
                            _offset_ModuleILPath = Offset_Reserved1 + 4;
                        }

                        return _offset_ModuleILPath;
                    }
                }

                private int Offset_ModuleNativePath
                {
                    get
                    {
                        if (_offset_ModuleNativePath == -1)
                        {
                            _offset_ModuleNativePath = Offset_ModuleILPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleILPath);
                        }

                        return _offset_ModuleNativePath;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ModuleNativePath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleNativePath);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ManagedPdbSignature
                {
                    get
                    {
                        if (_offset_ManagedPdbSignature == -1)
                        {
                            _offset_ManagedPdbSignature = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ManagedPdbSignature;
                    }
                }

                private int Offset_ManagedPdbAge
                {
                    get
                    {
                        if (_offset_ManagedPdbAge == -1)
                        {
                            _offset_ManagedPdbAge = Offset_ManagedPdbSignature + 16;
                        }

                        return _offset_ManagedPdbAge;
                    }
                }

                private int Offset_ManagedPdbBuildPath
                {
                    get
                    {
                        if (_offset_ManagedPdbBuildPath == -1)
                        {
                            _offset_ManagedPdbBuildPath = Offset_ManagedPdbAge + 4;
                        }

                        return _offset_ManagedPdbBuildPath;
                    }
                }

                private int Offset_NativePdbSignature
                {
                    get
                    {
                        if (_offset_NativePdbSignature == -1)
                        {
                            _offset_NativePdbSignature = Offset_ManagedPdbBuildPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedPdbBuildPath);
                        }

                        return _offset_NativePdbSignature;
                    }
                }

                private int Offset_NativePdbAge
                {
                    get
                    {
                        if (_offset_NativePdbAge == -1)
                        {
                            _offset_NativePdbAge = Offset_NativePdbSignature + 16;
                        }

                        return _offset_NativePdbAge;
                    }
                }

                private int Offset_NativePdbBuildPath
                {
                    get
                    {
                        if (_offset_NativePdbBuildPath == -1)
                        {
                            _offset_NativePdbBuildPath = Offset_NativePdbAge + 4;
                        }

                        return _offset_NativePdbBuildPath;
                    }
                }

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the ModuleFlags field.
                /// </summary>
                public ModuleFlagsMap ModuleFlags => (ModuleFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_ModuleFlags..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public uint Reserved1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reserved1..]);

                /// <summary>
                /// Retrieves the ModuleILPath field.
                /// </summary>
                public string ModuleILPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleILPath..]);

                /// <summary>
                /// Retrieves the ModuleNativePath field.
                /// </summary>
                public string ModuleNativePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleNativePath..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ManagedPdbSignature field.
                /// </summary>
                public Guid ManagedPdbSignature => new(_etwEvent.Data[Offset_ManagedPdbSignature..]);

                /// <summary>
                /// Retrieves the ManagedPdbAge field.
                /// </summary>
                public uint ManagedPdbAge => BitConverter.ToUInt32(_etwEvent.Data[Offset_ManagedPdbAge..]);

                /// <summary>
                /// Retrieves the ManagedPdbBuildPath field.
                /// </summary>
                public string ManagedPdbBuildPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedPdbBuildPath..]);

                /// <summary>
                /// Retrieves the NativePdbSignature field.
                /// </summary>
                public Guid NativePdbSignature => new(_etwEvent.Data[Offset_NativePdbSignature..]);

                /// <summary>
                /// Retrieves the NativePdbAge field.
                /// </summary>
                public uint NativePdbAge => BitConverter.ToUInt32(_etwEvent.Data[Offset_NativePdbAge..]);

                /// <summary>
                /// Retrieves the NativePdbBuildPath field.
                /// </summary>
                public string NativePdbBuildPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_NativePdbBuildPath..]);

                /// <summary>
                /// Creates a new LoaderModuleLoadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderModuleLoadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ModuleID = -1;
                    _offset_AssemblyID = -1;
                    _offset_ModuleFlags = -1;
                    _offset_Reserved1 = -1;
                    _offset_ModuleILPath = -1;
                    _offset_ModuleNativePath = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ManagedPdbSignature = -1;
                    _offset_ManagedPdbAge = -1;
                    _offset_ManagedPdbBuildPath = -1;
                    _offset_NativePdbSignature = -1;
                    _offset_NativePdbAge = -1;
                    _offset_NativePdbBuildPath = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a LoaderModuleUnload event.
        /// </summary>
        public readonly ref struct LoaderModuleUnloadEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "LoaderModuleUnload";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 153,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.DestoryGCHandle,
                Task = (ushort)Tasks.Loader,
                Keyword = (ulong)Keywords.LoaderKeyword | (ulong)Keywords.PerfTrackKeyword
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
            public LoaderModuleUnloadData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new LoaderModuleUnloadEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public LoaderModuleUnloadEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a LoaderModuleUnload event.
            /// </summary>
            public ref struct LoaderModuleUnloadData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ModuleID;
                private int _offset_AssemblyID;
                private int _offset_ModuleFlags;
                private int _offset_Reserved1;
                private int _offset_ModuleILPath;
                private int _offset_ModuleNativePath;
                private int _offset_ClrInstanceID;
                private int _offset_ManagedPdbSignature;
                private int _offset_ManagedPdbAge;
                private int _offset_ManagedPdbBuildPath;
                private int _offset_NativePdbSignature;
                private int _offset_NativePdbAge;
                private int _offset_NativePdbBuildPath;

                private int Offset_ModuleID
                {
                    get
                    {
                        if (_offset_ModuleID == -1)
                        {
                            _offset_ModuleID = 0;
                        }

                        return _offset_ModuleID;
                    }
                }

                private int Offset_AssemblyID
                {
                    get
                    {
                        if (_offset_AssemblyID == -1)
                        {
                            _offset_AssemblyID = Offset_ModuleID + 8;
                        }

                        return _offset_AssemblyID;
                    }
                }

                private int Offset_ModuleFlags
                {
                    get
                    {
                        if (_offset_ModuleFlags == -1)
                        {
                            _offset_ModuleFlags = Offset_AssemblyID + 8;
                        }

                        return _offset_ModuleFlags;
                    }
                }

                private int Offset_Reserved1
                {
                    get
                    {
                        if (_offset_Reserved1 == -1)
                        {
                            _offset_Reserved1 = Offset_ModuleFlags + 4;
                        }

                        return _offset_Reserved1;
                    }
                }

                private int Offset_ModuleILPath
                {
                    get
                    {
                        if (_offset_ModuleILPath == -1)
                        {
                            _offset_ModuleILPath = Offset_Reserved1 + 4;
                        }

                        return _offset_ModuleILPath;
                    }
                }

                private int Offset_ModuleNativePath
                {
                    get
                    {
                        if (_offset_ModuleNativePath == -1)
                        {
                            _offset_ModuleNativePath = Offset_ModuleILPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleILPath);
                        }

                        return _offset_ModuleNativePath;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_ModuleNativePath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ModuleNativePath);
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_ManagedPdbSignature
                {
                    get
                    {
                        if (_offset_ManagedPdbSignature == -1)
                        {
                            _offset_ManagedPdbSignature = Offset_ClrInstanceID + 2;
                        }

                        return _offset_ManagedPdbSignature;
                    }
                }

                private int Offset_ManagedPdbAge
                {
                    get
                    {
                        if (_offset_ManagedPdbAge == -1)
                        {
                            _offset_ManagedPdbAge = Offset_ManagedPdbSignature + 16;
                        }

                        return _offset_ManagedPdbAge;
                    }
                }

                private int Offset_ManagedPdbBuildPath
                {
                    get
                    {
                        if (_offset_ManagedPdbBuildPath == -1)
                        {
                            _offset_ManagedPdbBuildPath = Offset_ManagedPdbAge + 4;
                        }

                        return _offset_ManagedPdbBuildPath;
                    }
                }

                private int Offset_NativePdbSignature
                {
                    get
                    {
                        if (_offset_NativePdbSignature == -1)
                        {
                            _offset_NativePdbSignature = Offset_ManagedPdbBuildPath + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_ManagedPdbBuildPath);
                        }

                        return _offset_NativePdbSignature;
                    }
                }

                private int Offset_NativePdbAge
                {
                    get
                    {
                        if (_offset_NativePdbAge == -1)
                        {
                            _offset_NativePdbAge = Offset_NativePdbSignature + 16;
                        }

                        return _offset_NativePdbAge;
                    }
                }

                private int Offset_NativePdbBuildPath
                {
                    get
                    {
                        if (_offset_NativePdbBuildPath == -1)
                        {
                            _offset_NativePdbBuildPath = Offset_NativePdbAge + 4;
                        }

                        return _offset_NativePdbBuildPath;
                    }
                }

                /// <summary>
                /// Retrieves the ModuleID field.
                /// </summary>
                public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

                /// <summary>
                /// Retrieves the AssemblyID field.
                /// </summary>
                public ulong AssemblyID => BitConverter.ToUInt64(_etwEvent.Data[Offset_AssemblyID..]);

                /// <summary>
                /// Retrieves the ModuleFlags field.
                /// </summary>
                public ModuleFlagsMap ModuleFlags => (ModuleFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_ModuleFlags..]);

                /// <summary>
                /// Retrieves the Reserved1 field.
                /// </summary>
                public uint Reserved1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reserved1..]);

                /// <summary>
                /// Retrieves the ModuleILPath field.
                /// </summary>
                public string ModuleILPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleILPath..]);

                /// <summary>
                /// Retrieves the ModuleNativePath field.
                /// </summary>
                public string ModuleNativePath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ModuleNativePath..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the ManagedPdbSignature field.
                /// </summary>
                public Guid ManagedPdbSignature => new(_etwEvent.Data[Offset_ManagedPdbSignature..]);

                /// <summary>
                /// Retrieves the ManagedPdbAge field.
                /// </summary>
                public uint ManagedPdbAge => BitConverter.ToUInt32(_etwEvent.Data[Offset_ManagedPdbAge..]);

                /// <summary>
                /// Retrieves the ManagedPdbBuildPath field.
                /// </summary>
                public string ManagedPdbBuildPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_ManagedPdbBuildPath..]);

                /// <summary>
                /// Retrieves the NativePdbSignature field.
                /// </summary>
                public Guid NativePdbSignature => new(_etwEvent.Data[Offset_NativePdbSignature..]);

                /// <summary>
                /// Retrieves the NativePdbAge field.
                /// </summary>
                public uint NativePdbAge => BitConverter.ToUInt32(_etwEvent.Data[Offset_NativePdbAge..]);

                /// <summary>
                /// Retrieves the NativePdbBuildPath field.
                /// </summary>
                public string NativePdbBuildPath => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_NativePdbBuildPath..]);

                /// <summary>
                /// Creates a new LoaderModuleUnloadData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public LoaderModuleUnloadData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ModuleID = -1;
                    _offset_AssemblyID = -1;
                    _offset_ModuleFlags = -1;
                    _offset_Reserved1 = -1;
                    _offset_ModuleILPath = -1;
                    _offset_ModuleNativePath = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_ManagedPdbSignature = -1;
                    _offset_ManagedPdbAge = -1;
                    _offset_ManagedPdbBuildPath = -1;
                    _offset_NativePdbSignature = -1;
                    _offset_NativePdbAge = -1;
                    _offset_NativePdbBuildPath = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCJoin event.
        /// </summary>
        public readonly ref struct GCJoinEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCJoin";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 203,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.GCJoin,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCJoinData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCJoinEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCJoinEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCJoin event.
            /// </summary>
            public ref struct GCJoinData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_Heap;
                private int _offset_JoinTime;
                private int _offset_JoinType;
                private int _offset_ClrInstanceID;
                private int _offset_JoinID;

                private int Offset_Heap
                {
                    get
                    {
                        if (_offset_Heap == -1)
                        {
                            _offset_Heap = 0;
                        }

                        return _offset_Heap;
                    }
                }

                private int Offset_JoinTime
                {
                    get
                    {
                        if (_offset_JoinTime == -1)
                        {
                            _offset_JoinTime = Offset_Heap + 4;
                        }

                        return _offset_JoinTime;
                    }
                }

                private int Offset_JoinType
                {
                    get
                    {
                        if (_offset_JoinType == -1)
                        {
                            _offset_JoinType = Offset_JoinTime + 4;
                        }

                        return _offset_JoinType;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_JoinType + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_JoinID
                {
                    get
                    {
                        if (_offset_JoinID == -1)
                        {
                            _offset_JoinID = Offset_ClrInstanceID + 2;
                        }

                        return _offset_JoinID;
                    }
                }

                /// <summary>
                /// Retrieves the Heap field.
                /// </summary>
                public uint Heap => BitConverter.ToUInt32(_etwEvent.Data[Offset_Heap..]);

                /// <summary>
                /// Retrieves the JoinTime field.
                /// </summary>
                public uint JoinTime => BitConverter.ToUInt32(_etwEvent.Data[Offset_JoinTime..]);

                /// <summary>
                /// Retrieves the JoinType field.
                /// </summary>
                public uint JoinType => BitConverter.ToUInt32(_etwEvent.Data[Offset_JoinType..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the JoinID field.
                /// </summary>
                public uint JoinID => BitConverter.ToUInt32(_etwEvent.Data[Offset_JoinID..]);

                /// <summary>
                /// Creates a new GCJoinData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCJoinData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_Heap = -1;
                    _offset_JoinTime = -1;
                    _offset_JoinType = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_JoinID = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCGlobalHeapHistory event.
        /// </summary>
        public readonly ref struct GCGlobalHeapHistoryEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCGlobalHeapHistory";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 205,
                Version = 2,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.GlobalHeapHistory,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCGlobalHeapHistoryData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCGlobalHeapHistoryEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCGlobalHeapHistoryEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCGlobalHeapHistory event.
            /// </summary>
            public ref struct GCGlobalHeapHistoryData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_FinalYoungestDesired;
                private int _offset_NumHeaps;
                private int _offset_CondemnedGeneration;
                private int _offset_Gen0ReductionCount;
                private int _offset_Reason;
                private int _offset_GlobalMechanisms;
                private int _offset_ClrInstanceID;
                private int _offset_PauseMode;
                private int _offset_MemoryPressure;

                private int Offset_FinalYoungestDesired
                {
                    get
                    {
                        if (_offset_FinalYoungestDesired == -1)
                        {
                            _offset_FinalYoungestDesired = 0;
                        }

                        return _offset_FinalYoungestDesired;
                    }
                }

                private int Offset_NumHeaps
                {
                    get
                    {
                        if (_offset_NumHeaps == -1)
                        {
                            _offset_NumHeaps = Offset_FinalYoungestDesired + 8;
                        }

                        return _offset_NumHeaps;
                    }
                }

                private int Offset_CondemnedGeneration
                {
                    get
                    {
                        if (_offset_CondemnedGeneration == -1)
                        {
                            _offset_CondemnedGeneration = Offset_NumHeaps + 4;
                        }

                        return _offset_CondemnedGeneration;
                    }
                }

                private int Offset_Gen0ReductionCount
                {
                    get
                    {
                        if (_offset_Gen0ReductionCount == -1)
                        {
                            _offset_Gen0ReductionCount = Offset_CondemnedGeneration + 4;
                        }

                        return _offset_Gen0ReductionCount;
                    }
                }

                private int Offset_Reason
                {
                    get
                    {
                        if (_offset_Reason == -1)
                        {
                            _offset_Reason = Offset_Gen0ReductionCount + 4;
                        }

                        return _offset_Reason;
                    }
                }

                private int Offset_GlobalMechanisms
                {
                    get
                    {
                        if (_offset_GlobalMechanisms == -1)
                        {
                            _offset_GlobalMechanisms = Offset_Reason + 4;
                        }

                        return _offset_GlobalMechanisms;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_GlobalMechanisms + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_PauseMode
                {
                    get
                    {
                        if (_offset_PauseMode == -1)
                        {
                            _offset_PauseMode = Offset_ClrInstanceID + 2;
                        }

                        return _offset_PauseMode;
                    }
                }

                private int Offset_MemoryPressure
                {
                    get
                    {
                        if (_offset_MemoryPressure == -1)
                        {
                            _offset_MemoryPressure = Offset_PauseMode + 4;
                        }

                        return _offset_MemoryPressure;
                    }
                }

                /// <summary>
                /// Retrieves the FinalYoungestDesired field.
                /// </summary>
                public ulong FinalYoungestDesired => BitConverter.ToUInt64(_etwEvent.Data[Offset_FinalYoungestDesired..]);

                /// <summary>
                /// Retrieves the NumHeaps field.
                /// </summary>
                public int NumHeaps => BitConverter.ToInt32(_etwEvent.Data[Offset_NumHeaps..]);

                /// <summary>
                /// Retrieves the CondemnedGeneration field.
                /// </summary>
                public uint CondemnedGeneration => BitConverter.ToUInt32(_etwEvent.Data[Offset_CondemnedGeneration..]);

                /// <summary>
                /// Retrieves the Gen0ReductionCount field.
                /// </summary>
                public uint Gen0ReductionCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_Gen0ReductionCount..]);

                /// <summary>
                /// Retrieves the Reason field.
                /// </summary>
                public uint Reason => BitConverter.ToUInt32(_etwEvent.Data[Offset_Reason..]);

                /// <summary>
                /// Retrieves the GlobalMechanisms field.
                /// </summary>
                public uint GlobalMechanisms => BitConverter.ToUInt32(_etwEvent.Data[Offset_GlobalMechanisms..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the PauseMode field.
                /// </summary>
                public uint PauseMode => BitConverter.ToUInt32(_etwEvent.Data[Offset_PauseMode..]);

                /// <summary>
                /// Retrieves the MemoryPressure field.
                /// </summary>
                public uint MemoryPressure => BitConverter.ToUInt32(_etwEvent.Data[Offset_MemoryPressure..]);

                /// <summary>
                /// Creates a new GCGlobalHeapHistoryData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCGlobalHeapHistoryData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_FinalYoungestDesired = -1;
                    _offset_NumHeaps = -1;
                    _offset_CondemnedGeneration = -1;
                    _offset_Gen0ReductionCount = -1;
                    _offset_Reason = -1;
                    _offset_GlobalMechanisms = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_PauseMode = -1;
                    _offset_MemoryPressure = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCAllocationTick event.
        /// </summary>
        public readonly ref struct GCAllocationTickEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCAllocationTick";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 10,
                Version = 3,
                Channel = 0,
                Level = EtwTraceLevel.Verbose,
                Opcode = (EtwEventOpcode)Opcodes.AllocationTick,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCAllocationTickData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCAllocationTickEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCAllocationTickEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCAllocationTick event.
            /// </summary>
            public ref struct GCAllocationTickData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_AllocationAmount;
                private int _offset_AllocationKind;
                private int _offset_ClrInstanceID;
                private int _offset_AllocationAmount64;
                private int _offset_TypeID;
                private int _offset_TypeName;
                private int _offset_HeapIndex;
                private int _offset_Address;

                private int Offset_AllocationAmount
                {
                    get
                    {
                        if (_offset_AllocationAmount == -1)
                        {
                            _offset_AllocationAmount = 0;
                        }

                        return _offset_AllocationAmount;
                    }
                }

                private int Offset_AllocationKind
                {
                    get
                    {
                        if (_offset_AllocationKind == -1)
                        {
                            _offset_AllocationKind = Offset_AllocationAmount + 4;
                        }

                        return _offset_AllocationKind;
                    }
                }

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = Offset_AllocationKind + 4;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_AllocationAmount64
                {
                    get
                    {
                        if (_offset_AllocationAmount64 == -1)
                        {
                            _offset_AllocationAmount64 = Offset_ClrInstanceID + 2;
                        }

                        return _offset_AllocationAmount64;
                    }
                }

                private int Offset_TypeID
                {
                    get
                    {
                        if (_offset_TypeID == -1)
                        {
                            _offset_TypeID = Offset_AllocationAmount64 + 8;
                        }

                        return _offset_TypeID;
                    }
                }

                private int Offset_TypeName
                {
                    get
                    {
                        if (_offset_TypeName == -1)
                        {
                            _offset_TypeName = Offset_TypeID + _etwEvent.AddressSize;
                        }

                        return _offset_TypeName;
                    }
                }

                private int Offset_HeapIndex
                {
                    get
                    {
                        if (_offset_HeapIndex == -1)
                        {
                            _offset_HeapIndex = Offset_TypeName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_TypeName);
                        }

                        return _offset_HeapIndex;
                    }
                }

                private int Offset_Address
                {
                    get
                    {
                        if (_offset_Address == -1)
                        {
                            _offset_Address = Offset_HeapIndex + 4;
                        }

                        return _offset_Address;
                    }
                }

                /// <summary>
                /// Retrieves the AllocationAmount field.
                /// </summary>
                public uint AllocationAmount => BitConverter.ToUInt32(_etwEvent.Data[Offset_AllocationAmount..]);

                /// <summary>
                /// Retrieves the AllocationKind field.
                /// </summary>
                public GCAllocationKindMap AllocationKind => (GCAllocationKindMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_AllocationKind..]);

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the AllocationAmount64 field.
                /// </summary>
                public ulong AllocationAmount64 => BitConverter.ToUInt64(_etwEvent.Data[Offset_AllocationAmount64..]);

                /// <summary>
                /// Retrieves the TypeID field.
                /// </summary>
                public ulong TypeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

                /// <summary>
                /// Retrieves the TypeName field.
                /// </summary>
                public string TypeName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_TypeName..]);

                /// <summary>
                /// Retrieves the HeapIndex field.
                /// </summary>
                public uint HeapIndex => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapIndex..]);

                /// <summary>
                /// Retrieves the Address field.
                /// </summary>
                public ulong Address => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Address..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

                /// <summary>
                /// Creates a new GCAllocationTickData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCAllocationTickData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_AllocationAmount = -1;
                    _offset_AllocationKind = -1;
                    _offset_ClrInstanceID = -1;
                    _offset_AllocationAmount64 = -1;
                    _offset_TypeID = -1;
                    _offset_TypeName = -1;
                    _offset_HeapIndex = -1;
                    _offset_Address = -1;
                }
            }

        }

        /// <summary>
        /// An event wrapper for a GCPerHeapHistory event.
        /// </summary>
        public readonly ref struct GCPerHeapHistoryEvent
        {
            private readonly EtwEvent _etwEvent;

            /// <summary>
            /// Event name.
            /// </summary>
            public const string Name = "GCPerHeapHistory";

            /// <summary>
            /// The event provider.
            /// </summary>
            public static readonly Guid Provider = Id;

            /// <summary>
            /// Event descriptor.
            /// </summary>
            public static EtwEventDescriptor Descriptor { get; } = new EtwEventDescriptor
            {
                Id = 204,
                Version = 3,
                Channel = 0,
                Level = EtwTraceLevel.Information,
                Opcode = (EtwEventOpcode)Opcodes.PerHeapHistory,
                Task = (ushort)Tasks.GC,
                Keyword = (ulong)Keywords.GCKeyword
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
            public GCPerHeapHistoryData Data => new(_etwEvent);

            /// <summary>
            /// Creates a new GCPerHeapHistoryEvent.
            /// </summary>
            /// <param name="etwEvent">The event.</param>
            public GCPerHeapHistoryEvent(EtwEvent etwEvent)
            {
                _etwEvent = etwEvent;
            }

            /// <summary>
            /// A data wrapper for a GCPerHeapHistory event.
            /// </summary>
            public ref struct GCPerHeapHistoryData
            {
                private readonly EtwEvent _etwEvent;

                private int _offset_ClrInstanceID;
                private int _offset_FreeListAllocated;
                private int _offset_FreeListRejected;
                private int _offset_EndOfSegAllocated;
                private int _offset_CondemnedAllocated;
                private int _offset_PinnedAllocated;
                private int _offset_PinnedAllocatedAdvance;
                private int _offset_RunningFreeListEfficiency;
                private int _offset_CondemnReasons0;
                private int _offset_CondemnReasons1;
                private int _offset_CompactMechanisms;
                private int _offset_ExpandMechanisms;
                private int _offset_HeapIndex;
                private int _offset_ExtraGen0Commit;
                private int _offset_Count;
                private int _offset_Values;

                private int Offset_ClrInstanceID
                {
                    get
                    {
                        if (_offset_ClrInstanceID == -1)
                        {
                            _offset_ClrInstanceID = 0;
                        }

                        return _offset_ClrInstanceID;
                    }
                }

                private int Offset_FreeListAllocated
                {
                    get
                    {
                        if (_offset_FreeListAllocated == -1)
                        {
                            _offset_FreeListAllocated = Offset_ClrInstanceID + 2;
                        }

                        return _offset_FreeListAllocated;
                    }
                }

                private int Offset_FreeListRejected
                {
                    get
                    {
                        if (_offset_FreeListRejected == -1)
                        {
                            _offset_FreeListRejected = Offset_FreeListAllocated + _etwEvent.AddressSize;
                        }

                        return _offset_FreeListRejected;
                    }
                }

                private int Offset_EndOfSegAllocated
                {
                    get
                    {
                        if (_offset_EndOfSegAllocated == -1)
                        {
                            _offset_EndOfSegAllocated = Offset_FreeListRejected + _etwEvent.AddressSize;
                        }

                        return _offset_EndOfSegAllocated;
                    }
                }

                private int Offset_CondemnedAllocated
                {
                    get
                    {
                        if (_offset_CondemnedAllocated == -1)
                        {
                            _offset_CondemnedAllocated = Offset_EndOfSegAllocated + _etwEvent.AddressSize;
                        }

                        return _offset_CondemnedAllocated;
                    }
                }

                private int Offset_PinnedAllocated
                {
                    get
                    {
                        if (_offset_PinnedAllocated == -1)
                        {
                            _offset_PinnedAllocated = Offset_CondemnedAllocated + _etwEvent.AddressSize;
                        }

                        return _offset_PinnedAllocated;
                    }
                }

                private int Offset_PinnedAllocatedAdvance
                {
                    get
                    {
                        if (_offset_PinnedAllocatedAdvance == -1)
                        {
                            _offset_PinnedAllocatedAdvance = Offset_PinnedAllocated + _etwEvent.AddressSize;
                        }

                        return _offset_PinnedAllocatedAdvance;
                    }
                }

                private int Offset_RunningFreeListEfficiency
                {
                    get
                    {
                        if (_offset_RunningFreeListEfficiency == -1)
                        {
                            _offset_RunningFreeListEfficiency = Offset_PinnedAllocatedAdvance + _etwEvent.AddressSize;
                        }

                        return _offset_RunningFreeListEfficiency;
                    }
                }

                private int Offset_CondemnReasons0
                {
                    get
                    {
                        if (_offset_CondemnReasons0 == -1)
                        {
                            _offset_CondemnReasons0 = Offset_RunningFreeListEfficiency + 4;
                        }

                        return _offset_CondemnReasons0;
                    }
                }

                private int Offset_CondemnReasons1
                {
                    get
                    {
                        if (_offset_CondemnReasons1 == -1)
                        {
                            _offset_CondemnReasons1 = Offset_CondemnReasons0 + 4;
                        }

                        return _offset_CondemnReasons1;
                    }
                }

                private int Offset_CompactMechanisms
                {
                    get
                    {
                        if (_offset_CompactMechanisms == -1)
                        {
                            _offset_CompactMechanisms = Offset_CondemnReasons1 + 4;
                        }

                        return _offset_CompactMechanisms;
                    }
                }

                private int Offset_ExpandMechanisms
                {
                    get
                    {
                        if (_offset_ExpandMechanisms == -1)
                        {
                            _offset_ExpandMechanisms = Offset_CompactMechanisms + 4;
                        }

                        return _offset_ExpandMechanisms;
                    }
                }

                private int Offset_HeapIndex
                {
                    get
                    {
                        if (_offset_HeapIndex == -1)
                        {
                            _offset_HeapIndex = Offset_ExpandMechanisms + 4;
                        }

                        return _offset_HeapIndex;
                    }
                }

                private int Offset_ExtraGen0Commit
                {
                    get
                    {
                        if (_offset_ExtraGen0Commit == -1)
                        {
                            _offset_ExtraGen0Commit = Offset_HeapIndex + 4;
                        }

                        return _offset_ExtraGen0Commit;
                    }
                }

                private int Offset_Count
                {
                    get
                    {
                        if (_offset_Count == -1)
                        {
                            _offset_Count = Offset_ExtraGen0Commit + _etwEvent.AddressSize;
                        }

                        return _offset_Count;
                    }
                }

                private int Offset_Values
                {
                    get
                    {
                        if (_offset_Values == -1)
                        {
                            _offset_Values = Offset_Count + 4;
                        }

                        return _offset_Values;
                    }
                }

                /// <summary>
                /// Retrieves the ClrInstanceID field.
                /// </summary>
                public ushort ClrInstanceID => BitConverter.ToUInt16(_etwEvent.Data[Offset_ClrInstanceID..]);

                /// <summary>
                /// Retrieves the FreeListAllocated field.
                /// </summary>
                public ulong FreeListAllocated => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeListAllocated..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeListAllocated..]);

                /// <summary>
                /// Retrieves the FreeListRejected field.
                /// </summary>
                public ulong FreeListRejected => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeListRejected..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeListRejected..]);

                /// <summary>
                /// Retrieves the EndOfSegAllocated field.
                /// </summary>
                public ulong EndOfSegAllocated => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_EndOfSegAllocated..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_EndOfSegAllocated..]);

                /// <summary>
                /// Retrieves the CondemnedAllocated field.
                /// </summary>
                public ulong CondemnedAllocated => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_CondemnedAllocated..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_CondemnedAllocated..]);

                /// <summary>
                /// Retrieves the PinnedAllocated field.
                /// </summary>
                public ulong PinnedAllocated => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_PinnedAllocated..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_PinnedAllocated..]);

                /// <summary>
                /// Retrieves the PinnedAllocatedAdvance field.
                /// </summary>
                public ulong PinnedAllocatedAdvance => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_PinnedAllocatedAdvance..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_PinnedAllocatedAdvance..]);

                /// <summary>
                /// Retrieves the RunningFreeListEfficiency field.
                /// </summary>
                public uint RunningFreeListEfficiency => BitConverter.ToUInt32(_etwEvent.Data[Offset_RunningFreeListEfficiency..]);

                /// <summary>
                /// Retrieves the CondemnReasons0 field.
                /// </summary>
                public uint CondemnReasons0 => BitConverter.ToUInt32(_etwEvent.Data[Offset_CondemnReasons0..]);

                /// <summary>
                /// Retrieves the CondemnReasons1 field.
                /// </summary>
                public uint CondemnReasons1 => BitConverter.ToUInt32(_etwEvent.Data[Offset_CondemnReasons1..]);

                /// <summary>
                /// Retrieves the CompactMechanisms field.
                /// </summary>
                public uint CompactMechanisms => BitConverter.ToUInt32(_etwEvent.Data[Offset_CompactMechanisms..]);

                /// <summary>
                /// Retrieves the ExpandMechanisms field.
                /// </summary>
                public uint ExpandMechanisms => BitConverter.ToUInt32(_etwEvent.Data[Offset_ExpandMechanisms..]);

                /// <summary>
                /// Retrieves the HeapIndex field.
                /// </summary>
                public uint HeapIndex => BitConverter.ToUInt32(_etwEvent.Data[Offset_HeapIndex..]);

                /// <summary>
                /// Retrieves the ExtraGen0Commit field.
                /// </summary>
                public ulong ExtraGen0Commit => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_ExtraGen0Commit..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_ExtraGen0Commit..]);

                /// <summary>
                /// Retrieves the Count field.
                /// </summary>
                public uint Count => BitConverter.ToUInt32(_etwEvent.Data[Offset_Count..]);

                /// <summary>
                /// Retrieves the Values field.
                /// </summary>
                public GCPerHeapHistoryValueEnumerable Values => new(_etwEvent, Offset_Values, Count);

                /// <summary>
                /// Creates a new GCPerHeapHistoryData.
                /// </summary>
                /// <param name="etwEvent">The event.</param>
                public GCPerHeapHistoryData(EtwEvent etwEvent)
                {
                    _etwEvent = etwEvent;
                    _offset_ClrInstanceID = -1;
                    _offset_FreeListAllocated = -1;
                    _offset_FreeListRejected = -1;
                    _offset_EndOfSegAllocated = -1;
                    _offset_CondemnedAllocated = -1;
                    _offset_PinnedAllocated = -1;
                    _offset_PinnedAllocatedAdvance = -1;
                    _offset_RunningFreeListEfficiency = -1;
                    _offset_CondemnReasons0 = -1;
                    _offset_CondemnReasons1 = -1;
                    _offset_CompactMechanisms = -1;
                    _offset_ExpandMechanisms = -1;
                    _offset_HeapIndex = -1;
                    _offset_ExtraGen0Commit = -1;
                    _offset_Count = -1;
                    _offset_Values = -1;
                }
            }

        }

        /// <summary>
        /// AppDomainFlagsMap.
        /// </summary>
        [Flags]
        public enum AppDomainFlagsMap : ulong
        {
            /// <summary>
            /// Default.
            /// </summary>
            Default = 0x0000000000000001,
            /// <summary>
            /// Executable.
            /// </summary>
            Executable = 0x0000000000000002,
            /// <summary>
            /// Shared.
            /// </summary>
            Shared = 0x0000000000000004,
        }

        /// <summary>
        /// AssemblyFlagsMap.
        /// </summary>
        [Flags]
        public enum AssemblyFlagsMap : ulong
        {
            /// <summary>
            /// DomainNeutral.
            /// </summary>
            DomainNeutral = 0x0000000000000001,
            /// <summary>
            /// Dynamic.
            /// </summary>
            Dynamic = 0x0000000000000002,
            /// <summary>
            /// Native.
            /// </summary>
            Native = 0x0000000000000004,
            /// <summary>
            /// Collectible.
            /// </summary>
            Collectible = 0x0000000000000008,
        }

        /// <summary>
        /// ContentionFlagsMap.
        /// </summary>
        public enum ContentionFlagsMap : ulong
        {
            /// <summary>
            /// Managed.
            /// </summary>
            Managed = 0,
            /// <summary>
            /// Native.
            /// </summary>
            Native = 1,
        }

        /// <summary>
        /// ExceptionThrownFlagsMap.
        /// </summary>
        [Flags]
        public enum ExceptionThrownFlagsMap : ulong
        {
            /// <summary>
            /// HasInnerException.
            /// </summary>
            HasInnerException = 0x0000000000000001,
            /// <summary>
            /// Nested.
            /// </summary>
            Nested = 0x0000000000000002,
            /// <summary>
            /// ReThrown.
            /// </summary>
            ReThrown = 0x0000000000000004,
            /// <summary>
            /// CorruptedState.
            /// </summary>
            CorruptedState = 0x0000000000000008,
            /// <summary>
            /// CLSCompliant.
            /// </summary>
            CLSCompliant = 0x0000000000000010,
        }

        /// <summary>
        /// GCAllocationKindMap.
        /// </summary>
        public enum GCAllocationKindMap : ulong
        {
            /// <summary>
            /// Small.
            /// </summary>
            Small = 0,
            /// <summary>
            /// Large.
            /// </summary>
            Large = 1,
        }

        /// <summary>
        /// GCHandleKindMap.
        /// </summary>
        public enum GCHandleKindMap : ulong
        {
            /// <summary>
            /// WeakShort.
            /// </summary>
            WeakShort = 0,
            /// <summary>
            /// WeakLong.
            /// </summary>
            WeakLong = 1,
            /// <summary>
            /// Strong.
            /// </summary>
            Strong = 2,
            /// <summary>
            /// Pinned.
            /// </summary>
            Pinned = 3,
            /// <summary>
            /// Variable.
            /// </summary>
            Variable = 4,
            /// <summary>
            /// RefCounted.
            /// </summary>
            RefCounted = 5,
            /// <summary>
            /// Dependent.
            /// </summary>
            Dependent = 6,
            /// <summary>
            /// AsyncPinned.
            /// </summary>
            AsyncPinned = 7,
            /// <summary>
            /// SizedRef.
            /// </summary>
            SizedRef = 8,
        }

        /// <summary>
        /// GCReasonMap.
        /// </summary>
        public enum GCReasonMap : ulong
        {
            /// <summary>
            /// AllocSmall.
            /// </summary>
            AllocSmall = 0,
            /// <summary>
            /// Induced.
            /// </summary>
            Induced = 1,
            /// <summary>
            /// LowMemory.
            /// </summary>
            LowMemory = 2,
            /// <summary>
            /// Empty.
            /// </summary>
            Empty = 3,
            /// <summary>
            /// AllocLarge.
            /// </summary>
            AllocLarge = 4,
            /// <summary>
            /// OutOfSpaceSmallObjectHeap.
            /// </summary>
            OutOfSpaceSmallObjectHeap = 5,
            /// <summary>
            /// OutOfSpaceLargeObjectHeap.
            /// </summary>
            OutOfSpaceLargeObjectHeap = 6,
            /// <summary>
            /// InducedNoForce.
            /// </summary>
            InducedNoForce = 7,
            /// <summary>
            /// Stress.
            /// </summary>
            Stress = 8,
            /// <summary>
            /// InducedLowMemory.
            /// </summary>
            InducedLowMemory = 9,
        }

        /// <summary>
        /// GCRootKindMap.
        /// </summary>
        public enum GCRootKindMap : ulong
        {
            /// <summary>
            /// Stack.
            /// </summary>
            Stack = 0,
            /// <summary>
            /// Finalizer.
            /// </summary>
            Finalizer = 1,
            /// <summary>
            /// Handle.
            /// </summary>
            Handle = 2,
            /// <summary>
            /// Older.
            /// </summary>
            Older = 3,
            /// <summary>
            /// SizedRef.
            /// </summary>
            SizedRef = 4,
            /// <summary>
            /// Overflow.
            /// </summary>
            Overflow = 5,
        }

        /// <summary>
        /// GCSegmentTypeMap.
        /// </summary>
        public enum GCSegmentTypeMap : ulong
        {
            /// <summary>
            /// SmallObjectHeap.
            /// </summary>
            SmallObjectHeap = 0,
            /// <summary>
            /// LargeObjectHeap.
            /// </summary>
            LargeObjectHeap = 1,
            /// <summary>
            /// ReadOnlyHeap.
            /// </summary>
            ReadOnlyHeap = 2,
        }

        /// <summary>
        /// GCSuspendEEReasonMap.
        /// </summary>
        public enum GCSuspendEEReasonMap : ulong
        {
            /// <summary>
            /// SuspendOther.
            /// </summary>
            SuspendOther = 0,
            /// <summary>
            /// SuspendForGC.
            /// </summary>
            SuspendForGC = 1,
            /// <summary>
            /// SuspendForAppDomainShutdown.
            /// </summary>
            SuspendForAppDomainShutdown = 2,
            /// <summary>
            /// SuspendForCodePitching.
            /// </summary>
            SuspendForCodePitching = 3,
            /// <summary>
            /// SuspendForShutdown.
            /// </summary>
            SuspendForShutdown = 4,
            /// <summary>
            /// SuspendForDebugger.
            /// </summary>
            SuspendForDebugger = 5,
            /// <summary>
            /// SuspendForGCPrep.
            /// </summary>
            SuspendForGCPrep = 6,
            /// <summary>
            /// SuspendForDebuggerSweep.
            /// </summary>
            SuspendForDebuggerSweep = 7,
        }

        /// <summary>
        /// GCTypeMap.
        /// </summary>
        public enum GCTypeMap : ulong
        {
            /// <summary>
            /// NonConcurrentGC.
            /// </summary>
            NonConcurrentGC = 0,
            /// <summary>
            /// BackgroundGC.
            /// </summary>
            BackgroundGC = 1,
            /// <summary>
            /// ForegroundGC.
            /// </summary>
            ForegroundGC = 2,
        }

        /// <summary>
        /// ILStubGeneratedFlagsMap.
        /// </summary>
        [Flags]
        public enum ILStubGeneratedFlagsMap : ulong
        {
            /// <summary>
            /// ReverseInterop.
            /// </summary>
            ReverseInterop = 0x0000000000000001,
            /// <summary>
            /// ComInterop.
            /// </summary>
            ComInterop = 0x0000000000000002,
            /// <summary>
            /// NGenedStub.
            /// </summary>
            NGenedStub = 0x0000000000000004,
            /// <summary>
            /// Delegate.
            /// </summary>
            Delegate = 0x0000000000000008,
            /// <summary>
            /// VarArg.
            /// </summary>
            VarArg = 0x0000000000000010,
            /// <summary>
            /// UnmanagedCallee.
            /// </summary>
            UnmanagedCallee = 0x0000000000000020,
        }

        /// <summary>
        /// MethodFlagsMap.
        /// </summary>
        [Flags]
        public enum MethodFlagsMap : ulong
        {
            /// <summary>
            /// Dynamic.
            /// </summary>
            Dynamic = 0x0000000000000001,
            /// <summary>
            /// Generic.
            /// </summary>
            Generic = 0x0000000000000002,
            /// <summary>
            /// HasSharedGenericCode.
            /// </summary>
            HasSharedGenericCode = 0x0000000000000004,
            /// <summary>
            /// Jitted.
            /// </summary>
            Jitted = 0x0000000000000008,
        }

        /// <summary>
        /// ModuleFlagsMap.
        /// </summary>
        [Flags]
        public enum ModuleFlagsMap : ulong
        {
            /// <summary>
            /// DomainNeutral.
            /// </summary>
            DomainNeutral = 0x0000000000000001,
            /// <summary>
            /// Native.
            /// </summary>
            Native = 0x0000000000000002,
            /// <summary>
            /// Dynamic.
            /// </summary>
            Dynamic = 0x0000000000000004,
            /// <summary>
            /// Manifest.
            /// </summary>
            Manifest = 0x0000000000000008,
        }

        /// <summary>
        /// ModuleRangeTypeMap.
        /// </summary>
        [Flags]
        public enum ModuleRangeTypeMap : ulong
        {
            /// <summary>
            /// ColdRange.
            /// </summary>
            ColdRange = 0x0000000000000004,
        }

        /// <summary>
        /// RuntimeSkuMap.
        /// </summary>
        [Flags]
        public enum RuntimeSkuMap : ulong
        {
            /// <summary>
            /// DesktopClr.
            /// </summary>
            DesktopClr = 0x0000000000000001,
            /// <summary>
            /// CoreClr.
            /// </summary>
            CoreClr = 0x0000000000000002,
        }

        /// <summary>
        /// StartupFlagsMap.
        /// </summary>
        [Flags]
        public enum StartupFlagsMap : ulong
        {
            /// <summary>
            /// CONCURRENT_GC.
            /// </summary>
            CONCURRENT_GC = 0x0000000000000001,
            /// <summary>
            /// LOADER_OPTIMIZATION_SINGLE_DOMAIN.
            /// </summary>
            LOADER_OPTIMIZATION_SINGLE_DOMAIN = 0x0000000000000002,
            /// <summary>
            /// LOADER_OPTIMIZATION_MULTI_DOMAIN.
            /// </summary>
            LOADER_OPTIMIZATION_MULTI_DOMAIN = 0x0000000000000004,
            /// <summary>
            /// LOADER_SAFEMODE.
            /// </summary>
            LOADER_SAFEMODE = 0x0000000000000010,
            /// <summary>
            /// LOADER_SETPREFERENCE.
            /// </summary>
            LOADER_SETPREFERENCE = 0x0000000000000100,
            /// <summary>
            /// SERVER_GC.
            /// </summary>
            SERVER_GC = 0x0000000000001000,
            /// <summary>
            /// HOARD_GC_VM.
            /// </summary>
            HOARD_GC_VM = 0x0000000000002000,
            /// <summary>
            /// SINGLE_VERSION_HOSTING_INTERFACE.
            /// </summary>
            SINGLE_VERSION_HOSTING_INTERFACE = 0x0000000000004000,
            /// <summary>
            /// LEGACY_IMPERSONATION.
            /// </summary>
            LEGACY_IMPERSONATION = 0x0000000000010000,
            /// <summary>
            /// DISABLE_COMMITTHREADSTACK.
            /// </summary>
            DISABLE_COMMITTHREADSTACK = 0x0000000000020000,
            /// <summary>
            /// ALWAYSFLOW_IMPERSONATION.
            /// </summary>
            ALWAYSFLOW_IMPERSONATION = 0x0000000000040000,
            /// <summary>
            /// TRIM_GC_COMMIT.
            /// </summary>
            TRIM_GC_COMMIT = 0x0000000000080000,
            /// <summary>
            /// ETW.
            /// </summary>
            ETW = 0x0000000000100000,
            /// <summary>
            /// SERVER_BUILD.
            /// </summary>
            SERVER_BUILD = 0x0000000000200000,
            /// <summary>
            /// ARM.
            /// </summary>
            ARM = 0x0000000000400000,
        }

        /// <summary>
        /// StartupModeMap.
        /// </summary>
        [Flags]
        public enum StartupModeMap : ulong
        {
            /// <summary>
            /// ManagedExe.
            /// </summary>
            ManagedExe = 0x0000000000000001,
            /// <summary>
            /// HostedClr.
            /// </summary>
            HostedClr = 0x0000000000000002,
            /// <summary>
            /// IjwDll.
            /// </summary>
            IjwDll = 0x0000000000000004,
            /// <summary>
            /// ComActivated.
            /// </summary>
            ComActivated = 0x0000000000000008,
            /// <summary>
            /// Other.
            /// </summary>
            Other = 0x0000000000000010,
        }

        /// <summary>
        /// TailCallTypeMap.
        /// </summary>
        public enum TailCallTypeMap : ulong
        {
            /// <summary>
            /// OptimizedTailCall.
            /// </summary>
            OptimizedTailCall = 0,
            /// <summary>
            /// RecursiveLoop.
            /// </summary>
            RecursiveLoop = 1,
            /// <summary>
            /// HelperAssistedTailCall.
            /// </summary>
            HelperAssistedTailCall = 2,
        }

        /// <summary>
        /// ThreadAdjustmentReasonMap.
        /// </summary>
        public enum ThreadAdjustmentReasonMap : ulong
        {
            /// <summary>
            /// Warmup.
            /// </summary>
            Warmup = 0,
            /// <summary>
            /// Initializing.
            /// </summary>
            Initializing = 1,
            /// <summary>
            /// RandomMove.
            /// </summary>
            RandomMove = 2,
            /// <summary>
            /// ClimbingMove.
            /// </summary>
            ClimbingMove = 3,
            /// <summary>
            /// ChangePoint.
            /// </summary>
            ChangePoint = 4,
            /// <summary>
            /// Stabilizing.
            /// </summary>
            Stabilizing = 5,
            /// <summary>
            /// Starvation.
            /// </summary>
            Starvation = 6,
            /// <summary>
            /// ThreadTimedOut.
            /// </summary>
            ThreadTimedOut = 7,
        }

        /// <summary>
        /// ThreadFlagsMap.
        /// </summary>
        [Flags]
        public enum ThreadFlagsMap : ulong
        {
            /// <summary>
            /// GCSpecial.
            /// </summary>
            GCSpecial = 0x0000000000000001,
            /// <summary>
            /// Finalizer.
            /// </summary>
            Finalizer = 0x0000000000000002,
            /// <summary>
            /// ThreadPoolWorker.
            /// </summary>
            ThreadPoolWorker = 0x0000000000000004,
        }

        /// <summary>
        /// GCRootCCWFlagsMap.
        /// </summary>
        [Flags]
        public enum GCRootCCWFlagsMap : ulong
        {
            /// <summary>
            /// Strong.
            /// </summary>
            Strong = 0x0000000000000001,
            /// <summary>
            /// Pegged.
            /// </summary>
            Pegged = 0x0000000000000002,
        }

        /// <summary>
        /// GCRootFlagsMap.
        /// </summary>
        [Flags]
        public enum GCRootFlagsMap : ulong
        {
            /// <summary>
            /// Pinning.
            /// </summary>
            Pinning = 0x0000000000000001,
            /// <summary>
            /// WeakRef.
            /// </summary>
            WeakRef = 0x0000000000000002,
            /// <summary>
            /// Interior.
            /// </summary>
            Interior = 0x0000000000000004,
            /// <summary>
            /// RefCounted.
            /// </summary>
            RefCounted = 0x0000000000000008,
        }

        /// <summary>
        /// GCRootStaticVarFlagsMap.
        /// </summary>
        [Flags]
        public enum GCRootStaticVarFlagsMap : ulong
        {
            /// <summary>
            /// ThreadLocal.
            /// </summary>
            ThreadLocal = 0x0000000000000001,
        }

        /// <summary>
        /// TypeFlagsMap.
        /// </summary>
        [Flags]
        public enum TypeFlagsMap : ulong
        {
            /// <summary>
            /// Delegate.
            /// </summary>
            Delegate = 0x0000000000000001,
            /// <summary>
            /// Finalizable.
            /// </summary>
            Finalizable = 0x0000000000000002,
            /// <summary>
            /// ExternallyImplementedCOMObject.
            /// </summary>
            ExternallyImplementedCOMObject = 0x0000000000000004,
            /// <summary>
            /// Array.
            /// </summary>
            Array = 0x0000000000000008,
        }

        /// <summary>
        /// A data wrapper for a TypeBulkTypeValue structure.
        /// </summary>
        public ref struct TypeBulkTypeValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_TypeID;
            private int _offset_ModuleID;
            private int _offset_TypeNameID;
            private int _offset_Flags;
            private int _offset_CorElementType;
            private int _offset_Name;
            private int _offset_TypeParameterCount;
            private int _offset_TypeParameters;
            private int _structSize;

            private int Offset_TypeID
            {
                get
                {
                    if (_offset_TypeID == -1)
                    {
                        _offset_TypeID = _offset + 0;
                    }

                    return _offset_TypeID;
                }
            }

            private int Offset_ModuleID
            {
                get
                {
                    if (_offset_ModuleID == -1)
                    {
                        _offset_ModuleID = Offset_TypeID + 8;
                    }

                    return _offset_ModuleID;
                }
            }

            private int Offset_TypeNameID
            {
                get
                {
                    if (_offset_TypeNameID == -1)
                    {
                        _offset_TypeNameID = Offset_ModuleID + 8;
                    }

                    return _offset_TypeNameID;
                }
            }

            private int Offset_Flags
            {
                get
                {
                    if (_offset_Flags == -1)
                    {
                        _offset_Flags = Offset_TypeNameID + 4;
                    }

                    return _offset_Flags;
                }
            }

            private int Offset_CorElementType
            {
                get
                {
                    if (_offset_CorElementType == -1)
                    {
                        _offset_CorElementType = Offset_Flags + 4;
                    }

                    return _offset_CorElementType;
                }
            }

            private int Offset_Name
            {
                get
                {
                    if (_offset_Name == -1)
                    {
                        _offset_Name = Offset_CorElementType + 1;
                    }

                    return _offset_Name;
                }
            }

            private int Offset_TypeParameterCount
            {
                get
                {
                    if (_offset_TypeParameterCount == -1)
                    {
                        _offset_TypeParameterCount = Offset_Name + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_Name);
                    }

                    return _offset_TypeParameterCount;
                }
            }

            private int Offset_TypeParameters
            {
                get
                {
                    if (_offset_TypeParameters == -1)
                    {
                        _offset_TypeParameters = Offset_TypeParameterCount + 4;
                    }

                    return _offset_TypeParameters;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_TypeParameters + (8 * (int)TypeParameterCount);
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the TypeID field.
            /// </summary>
            public ulong TypeID => BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

            /// <summary>
            /// Retrieves the ModuleID field.
            /// </summary>
            public ulong ModuleID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ModuleID..]);

            /// <summary>
            /// Retrieves the TypeNameID field.
            /// </summary>
            public uint TypeNameID => BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeNameID..]);

            /// <summary>
            /// Retrieves the Flags field.
            /// </summary>
            public TypeFlagsMap Flags => (TypeFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Flags..]);

            /// <summary>
            /// Retrieves the CorElementType field.
            /// </summary>
            public byte CorElementType => _etwEvent.Data[Offset_CorElementType];

            /// <summary>
            /// Retrieves the Name field.
            /// </summary>
            public string Name => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_Name..]);

            /// <summary>
            /// Retrieves the TypeParameterCount field.
            /// </summary>
            public uint TypeParameterCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_TypeParameterCount..]);

            /// <summary>
            /// Retrieves the TypeParameters field.
            /// </summary>
            public EtwEvent.StructEnumerable<ulong> TypeParameters => new(_etwEvent, Offset_TypeParameters, TypeParameterCount);

            /// <summary>
            /// Creates a new TypeBulkTypeValue.
            /// </summary>
            public TypeBulkTypeValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_TypeID = -1;
                _offset_ModuleID = -1;
                _offset_TypeNameID = -1;
                _offset_Flags = -1;
                _offset_CorElementType = -1;
                _offset_Name = -1;
                _offset_TypeParameterCount = -1;
                _offset_TypeParameters = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate TypeBulkTypeValue structures.
        /// </summary>
        public ref struct TypeBulkTypeValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal TypeBulkTypeValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal TypeBulkTypeValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public TypeBulkTypeValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an TypeBulkTypeValue collection.
            /// </summary>
            public ref struct TypeBulkTypeValueEnumerator
            {
                private readonly TypeBulkTypeValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public TypeBulkTypeValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal TypeBulkTypeValueEnumerator(TypeBulkTypeValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkRootEdgeValue structure.
        /// </summary>
        public ref struct GCBulkRootEdgeValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_RootedNodeAddress;
            private int _offset_GCRootKind;
            private int _offset_GCRootFlag;
            private int _offset_GCRootID;
            private int _structSize;

            private int Offset_RootedNodeAddress
            {
                get
                {
                    if (_offset_RootedNodeAddress == -1)
                    {
                        _offset_RootedNodeAddress = _offset + 0;
                    }

                    return _offset_RootedNodeAddress;
                }
            }

            private int Offset_GCRootKind
            {
                get
                {
                    if (_offset_GCRootKind == -1)
                    {
                        _offset_GCRootKind = Offset_RootedNodeAddress + _etwEvent.AddressSize;
                    }

                    return _offset_GCRootKind;
                }
            }

            private int Offset_GCRootFlag
            {
                get
                {
                    if (_offset_GCRootFlag == -1)
                    {
                        _offset_GCRootFlag = Offset_GCRootKind + 1;
                    }

                    return _offset_GCRootFlag;
                }
            }

            private int Offset_GCRootID
            {
                get
                {
                    if (_offset_GCRootID == -1)
                    {
                        _offset_GCRootID = Offset_GCRootFlag + 4;
                    }

                    return _offset_GCRootID;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_GCRootID + _etwEvent.AddressSize;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the RootedNodeAddress field.
            /// </summary>
            public ulong RootedNodeAddress => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_RootedNodeAddress..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_RootedNodeAddress..]);

            /// <summary>
            /// Retrieves the GCRootKind field.
            /// </summary>
            public GCRootKindMap GCRootKind => (GCRootKindMap)_etwEvent.Data[Offset_GCRootKind];

            /// <summary>
            /// Retrieves the GCRootFlag field.
            /// </summary>
            public GCRootFlagsMap GCRootFlag => (GCRootFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_GCRootFlag..]);

            /// <summary>
            /// Retrieves the GCRootID field.
            /// </summary>
            public ulong GCRootID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_GCRootID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_GCRootID..]);

            /// <summary>
            /// Creates a new GCBulkRootEdgeValue.
            /// </summary>
            public GCBulkRootEdgeValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_RootedNodeAddress = -1;
                _offset_GCRootKind = -1;
                _offset_GCRootFlag = -1;
                _offset_GCRootID = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkRootEdgeValue structures.
        /// </summary>
        public ref struct GCBulkRootEdgeValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkRootEdgeValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkRootEdgeValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkRootEdgeValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkRootEdgeValue collection.
            /// </summary>
            public ref struct GCBulkRootEdgeValueEnumerator
            {
                private readonly GCBulkRootEdgeValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkRootEdgeValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkRootEdgeValueEnumerator(GCBulkRootEdgeValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkRootConditionalWeakTableElementEdgeValue structure.
        /// </summary>
        public ref struct GCBulkRootConditionalWeakTableElementEdgeValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_GCKeyNodeID;
            private int _offset_GCValueNodeID;
            private int _offset_GCRootID;
            private int _structSize;

            private int Offset_GCKeyNodeID
            {
                get
                {
                    if (_offset_GCKeyNodeID == -1)
                    {
                        _offset_GCKeyNodeID = _offset + 0;
                    }

                    return _offset_GCKeyNodeID;
                }
            }

            private int Offset_GCValueNodeID
            {
                get
                {
                    if (_offset_GCValueNodeID == -1)
                    {
                        _offset_GCValueNodeID = Offset_GCKeyNodeID + _etwEvent.AddressSize;
                    }

                    return _offset_GCValueNodeID;
                }
            }

            private int Offset_GCRootID
            {
                get
                {
                    if (_offset_GCRootID == -1)
                    {
                        _offset_GCRootID = Offset_GCValueNodeID + _etwEvent.AddressSize;
                    }

                    return _offset_GCRootID;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_GCRootID + _etwEvent.AddressSize;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the GCKeyNodeID field.
            /// </summary>
            public ulong GCKeyNodeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_GCKeyNodeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_GCKeyNodeID..]);

            /// <summary>
            /// Retrieves the GCValueNodeID field.
            /// </summary>
            public ulong GCValueNodeID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_GCValueNodeID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_GCValueNodeID..]);

            /// <summary>
            /// Retrieves the GCRootID field.
            /// </summary>
            public ulong GCRootID => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_GCRootID..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_GCRootID..]);

            /// <summary>
            /// Creates a new GCBulkRootConditionalWeakTableElementEdgeValue.
            /// </summary>
            public GCBulkRootConditionalWeakTableElementEdgeValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_GCKeyNodeID = -1;
                _offset_GCValueNodeID = -1;
                _offset_GCRootID = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkRootConditionalWeakTableElementEdgeValue structures.
        /// </summary>
        public ref struct GCBulkRootConditionalWeakTableElementEdgeValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkRootConditionalWeakTableElementEdgeValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkRootConditionalWeakTableElementEdgeValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkRootConditionalWeakTableElementEdgeValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkRootConditionalWeakTableElementEdgeValue collection.
            /// </summary>
            public ref struct GCBulkRootConditionalWeakTableElementEdgeValueEnumerator
            {
                private readonly GCBulkRootConditionalWeakTableElementEdgeValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkRootConditionalWeakTableElementEdgeValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkRootConditionalWeakTableElementEdgeValueEnumerator(GCBulkRootConditionalWeakTableElementEdgeValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkNodeValue structure.
        /// </summary>
        public ref struct GCBulkNodeValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_Address;
            private int _offset_Size;
            private int _offset_TypeID;
            private int _offset_EdgeCount;
            private int _structSize;

            private int Offset_Address
            {
                get
                {
                    if (_offset_Address == -1)
                    {
                        _offset_Address = _offset + 0;
                    }

                    return _offset_Address;
                }
            }

            private int Offset_Size
            {
                get
                {
                    if (_offset_Size == -1)
                    {
                        _offset_Size = Offset_Address + _etwEvent.AddressSize;
                    }

                    return _offset_Size;
                }
            }

            private int Offset_TypeID
            {
                get
                {
                    if (_offset_TypeID == -1)
                    {
                        _offset_TypeID = Offset_Size + 8;
                    }

                    return _offset_TypeID;
                }
            }

            private int Offset_EdgeCount
            {
                get
                {
                    if (_offset_EdgeCount == -1)
                    {
                        _offset_EdgeCount = Offset_TypeID + 8;
                    }

                    return _offset_EdgeCount;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_EdgeCount + 8;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the Address field.
            /// </summary>
            public ulong Address => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Address..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Address..]);

            /// <summary>
            /// Retrieves the Size field.
            /// </summary>
            public ulong Size => BitConverter.ToUInt64(_etwEvent.Data[Offset_Size..]);

            /// <summary>
            /// Retrieves the TypeID field.
            /// </summary>
            public ulong TypeID => BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

            /// <summary>
            /// Retrieves the EdgeCount field.
            /// </summary>
            public ulong EdgeCount => BitConverter.ToUInt64(_etwEvent.Data[Offset_EdgeCount..]);

            /// <summary>
            /// Creates a new GCBulkNodeValue.
            /// </summary>
            public GCBulkNodeValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_Address = -1;
                _offset_Size = -1;
                _offset_TypeID = -1;
                _offset_EdgeCount = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkNodeValue structures.
        /// </summary>
        public ref struct GCBulkNodeValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkNodeValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkNodeValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkNodeValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkNodeValue collection.
            /// </summary>
            public ref struct GCBulkNodeValueEnumerator
            {
                private readonly GCBulkNodeValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkNodeValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkNodeValueEnumerator(GCBulkNodeValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkEdgeValue structure.
        /// </summary>
        public ref struct GCBulkEdgeValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_Value;
            private int _offset_ReferencingFieldID;
            private int _structSize;

            private int Offset_Value
            {
                get
                {
                    if (_offset_Value == -1)
                    {
                        _offset_Value = _offset + 0;
                    }

                    return _offset_Value;
                }
            }

            private int Offset_ReferencingFieldID
            {
                get
                {
                    if (_offset_ReferencingFieldID == -1)
                    {
                        _offset_ReferencingFieldID = Offset_Value + _etwEvent.AddressSize;
                    }

                    return _offset_ReferencingFieldID;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_ReferencingFieldID + 4;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the Value field.
            /// </summary>
            public ulong Value => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_Value..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_Value..]);

            /// <summary>
            /// Retrieves the ReferencingFieldID field.
            /// </summary>
            public uint ReferencingFieldID => BitConverter.ToUInt32(_etwEvent.Data[Offset_ReferencingFieldID..]);

            /// <summary>
            /// Creates a new GCBulkEdgeValue.
            /// </summary>
            public GCBulkEdgeValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_Value = -1;
                _offset_ReferencingFieldID = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkEdgeValue structures.
        /// </summary>
        public ref struct GCBulkEdgeValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkEdgeValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkEdgeValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkEdgeValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkEdgeValue collection.
            /// </summary>
            public ref struct GCBulkEdgeValueEnumerator
            {
                private readonly GCBulkEdgeValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkEdgeValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkEdgeValueEnumerator(GCBulkEdgeValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkSurvivingObjectRangesValue structure.
        /// </summary>
        public ref struct GCBulkSurvivingObjectRangesValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_RangeBase;
            private int _offset_RangeLength;
            private int _structSize;

            private int Offset_RangeBase
            {
                get
                {
                    if (_offset_RangeBase == -1)
                    {
                        _offset_RangeBase = _offset + 0;
                    }

                    return _offset_RangeBase;
                }
            }

            private int Offset_RangeLength
            {
                get
                {
                    if (_offset_RangeLength == -1)
                    {
                        _offset_RangeLength = Offset_RangeBase + _etwEvent.AddressSize;
                    }

                    return _offset_RangeLength;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_RangeLength + 8;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the RangeBase field.
            /// </summary>
            public ulong RangeBase => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_RangeBase..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeBase..]);

            /// <summary>
            /// Retrieves the RangeLength field.
            /// </summary>
            public ulong RangeLength => BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeLength..]);

            /// <summary>
            /// Creates a new GCBulkSurvivingObjectRangesValue.
            /// </summary>
            public GCBulkSurvivingObjectRangesValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_RangeBase = -1;
                _offset_RangeLength = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkSurvivingObjectRangesValue structures.
        /// </summary>
        public ref struct GCBulkSurvivingObjectRangesValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkSurvivingObjectRangesValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkSurvivingObjectRangesValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkSurvivingObjectRangesValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkSurvivingObjectRangesValue collection.
            /// </summary>
            public ref struct GCBulkSurvivingObjectRangesValueEnumerator
            {
                private readonly GCBulkSurvivingObjectRangesValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkSurvivingObjectRangesValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkSurvivingObjectRangesValueEnumerator(GCBulkSurvivingObjectRangesValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkMovedObjectRangesValue structure.
        /// </summary>
        public ref struct GCBulkMovedObjectRangesValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_OldRangeBase;
            private int _offset_NewRangeBase;
            private int _offset_RangeLength;
            private int _structSize;

            private int Offset_OldRangeBase
            {
                get
                {
                    if (_offset_OldRangeBase == -1)
                    {
                        _offset_OldRangeBase = _offset + 0;
                    }

                    return _offset_OldRangeBase;
                }
            }

            private int Offset_NewRangeBase
            {
                get
                {
                    if (_offset_NewRangeBase == -1)
                    {
                        _offset_NewRangeBase = Offset_OldRangeBase + _etwEvent.AddressSize;
                    }

                    return _offset_NewRangeBase;
                }
            }

            private int Offset_RangeLength
            {
                get
                {
                    if (_offset_RangeLength == -1)
                    {
                        _offset_RangeLength = Offset_NewRangeBase + _etwEvent.AddressSize;
                    }

                    return _offset_RangeLength;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_RangeLength + 8;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the OldRangeBase field.
            /// </summary>
            public ulong OldRangeBase => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_OldRangeBase..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_OldRangeBase..]);

            /// <summary>
            /// Retrieves the NewRangeBase field.
            /// </summary>
            public ulong NewRangeBase => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NewRangeBase..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NewRangeBase..]);

            /// <summary>
            /// Retrieves the RangeLength field.
            /// </summary>
            public ulong RangeLength => BitConverter.ToUInt64(_etwEvent.Data[Offset_RangeLength..]);

            /// <summary>
            /// Creates a new GCBulkMovedObjectRangesValue.
            /// </summary>
            public GCBulkMovedObjectRangesValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_OldRangeBase = -1;
                _offset_NewRangeBase = -1;
                _offset_RangeLength = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkMovedObjectRangesValue structures.
        /// </summary>
        public ref struct GCBulkMovedObjectRangesValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkMovedObjectRangesValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkMovedObjectRangesValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkMovedObjectRangesValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkMovedObjectRangesValue collection.
            /// </summary>
            public ref struct GCBulkMovedObjectRangesValueEnumerator
            {
                private readonly GCBulkMovedObjectRangesValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkMovedObjectRangesValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkMovedObjectRangesValueEnumerator(GCBulkMovedObjectRangesValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkRootCCWValue structure.
        /// </summary>
        public ref struct GCBulkRootCCWValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_GCRootID;
            private int _offset_ObjectID;
            private int _offset_TypeID;
            private int _offset_IUnknown;
            private int _offset_RefCount;
            private int _offset_PeggedRefCount;
            private int _offset_Flags;
            private int _structSize;

            private int Offset_GCRootID
            {
                get
                {
                    if (_offset_GCRootID == -1)
                    {
                        _offset_GCRootID = _offset + 0;
                    }

                    return _offset_GCRootID;
                }
            }

            private int Offset_ObjectID
            {
                get
                {
                    if (_offset_ObjectID == -1)
                    {
                        _offset_ObjectID = Offset_GCRootID + 8;
                    }

                    return _offset_ObjectID;
                }
            }

            private int Offset_TypeID
            {
                get
                {
                    if (_offset_TypeID == -1)
                    {
                        _offset_TypeID = Offset_ObjectID + 8;
                    }

                    return _offset_TypeID;
                }
            }

            private int Offset_IUnknown
            {
                get
                {
                    if (_offset_IUnknown == -1)
                    {
                        _offset_IUnknown = Offset_TypeID + 8;
                    }

                    return _offset_IUnknown;
                }
            }

            private int Offset_RefCount
            {
                get
                {
                    if (_offset_RefCount == -1)
                    {
                        _offset_RefCount = Offset_IUnknown + 8;
                    }

                    return _offset_RefCount;
                }
            }

            private int Offset_PeggedRefCount
            {
                get
                {
                    if (_offset_PeggedRefCount == -1)
                    {
                        _offset_PeggedRefCount = Offset_RefCount + 4;
                    }

                    return _offset_PeggedRefCount;
                }
            }

            private int Offset_Flags
            {
                get
                {
                    if (_offset_Flags == -1)
                    {
                        _offset_Flags = Offset_PeggedRefCount + 4;
                    }

                    return _offset_Flags;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_Flags + 4;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the GCRootID field.
            /// </summary>
            public ulong GCRootID => BitConverter.ToUInt64(_etwEvent.Data[Offset_GCRootID..]);

            /// <summary>
            /// Retrieves the ObjectID field.
            /// </summary>
            public ulong ObjectID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

            /// <summary>
            /// Retrieves the TypeID field.
            /// </summary>
            public ulong TypeID => BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

            /// <summary>
            /// Retrieves the IUnknown field.
            /// </summary>
            public ulong IUnknown => BitConverter.ToUInt64(_etwEvent.Data[Offset_IUnknown..]);

            /// <summary>
            /// Retrieves the RefCount field.
            /// </summary>
            public uint RefCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RefCount..]);

            /// <summary>
            /// Retrieves the PeggedRefCount field.
            /// </summary>
            public uint PeggedRefCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_PeggedRefCount..]);

            /// <summary>
            /// Retrieves the Flags field.
            /// </summary>
            public GCRootCCWFlagsMap Flags => (GCRootCCWFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Flags..]);

            /// <summary>
            /// Creates a new GCBulkRootCCWValue.
            /// </summary>
            public GCBulkRootCCWValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_GCRootID = -1;
                _offset_ObjectID = -1;
                _offset_TypeID = -1;
                _offset_IUnknown = -1;
                _offset_RefCount = -1;
                _offset_PeggedRefCount = -1;
                _offset_Flags = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkRootCCWValue structures.
        /// </summary>
        public ref struct GCBulkRootCCWValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkRootCCWValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkRootCCWValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkRootCCWValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkRootCCWValue collection.
            /// </summary>
            public ref struct GCBulkRootCCWValueEnumerator
            {
                private readonly GCBulkRootCCWValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkRootCCWValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkRootCCWValueEnumerator(GCBulkRootCCWValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkRCWValue structure.
        /// </summary>
        public ref struct GCBulkRCWValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_ObjectID;
            private int _offset_TypeID;
            private int _offset_IUnknown;
            private int _offset_VTable;
            private int _offset_RefCount;
            private int _offset_Flags;
            private int _structSize;

            private int Offset_ObjectID
            {
                get
                {
                    if (_offset_ObjectID == -1)
                    {
                        _offset_ObjectID = _offset + 0;
                    }

                    return _offset_ObjectID;
                }
            }

            private int Offset_TypeID
            {
                get
                {
                    if (_offset_TypeID == -1)
                    {
                        _offset_TypeID = Offset_ObjectID + 8;
                    }

                    return _offset_TypeID;
                }
            }

            private int Offset_IUnknown
            {
                get
                {
                    if (_offset_IUnknown == -1)
                    {
                        _offset_IUnknown = Offset_TypeID + 8;
                    }

                    return _offset_IUnknown;
                }
            }

            private int Offset_VTable
            {
                get
                {
                    if (_offset_VTable == -1)
                    {
                        _offset_VTable = Offset_IUnknown + 8;
                    }

                    return _offset_VTable;
                }
            }

            private int Offset_RefCount
            {
                get
                {
                    if (_offset_RefCount == -1)
                    {
                        _offset_RefCount = Offset_VTable + 8;
                    }

                    return _offset_RefCount;
                }
            }

            private int Offset_Flags
            {
                get
                {
                    if (_offset_Flags == -1)
                    {
                        _offset_Flags = Offset_RefCount + 4;
                    }

                    return _offset_Flags;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_Flags + 4;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the ObjectID field.
            /// </summary>
            public ulong ObjectID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

            /// <summary>
            /// Retrieves the TypeID field.
            /// </summary>
            public ulong TypeID => BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

            /// <summary>
            /// Retrieves the IUnknown field.
            /// </summary>
            public ulong IUnknown => BitConverter.ToUInt64(_etwEvent.Data[Offset_IUnknown..]);

            /// <summary>
            /// Retrieves the VTable field.
            /// </summary>
            public ulong VTable => BitConverter.ToUInt64(_etwEvent.Data[Offset_VTable..]);

            /// <summary>
            /// Retrieves the RefCount field.
            /// </summary>
            public uint RefCount => BitConverter.ToUInt32(_etwEvent.Data[Offset_RefCount..]);

            /// <summary>
            /// Retrieves the Flags field.
            /// </summary>
            public uint Flags => BitConverter.ToUInt32(_etwEvent.Data[Offset_Flags..]);

            /// <summary>
            /// Creates a new GCBulkRCWValue.
            /// </summary>
            public GCBulkRCWValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_ObjectID = -1;
                _offset_TypeID = -1;
                _offset_IUnknown = -1;
                _offset_VTable = -1;
                _offset_RefCount = -1;
                _offset_Flags = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkRCWValue structures.
        /// </summary>
        public ref struct GCBulkRCWValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkRCWValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkRCWValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkRCWValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkRCWValue collection.
            /// </summary>
            public ref struct GCBulkRCWValueEnumerator
            {
                private readonly GCBulkRCWValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkRCWValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkRCWValueEnumerator(GCBulkRCWValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCBulkRootStaticVarValue structure.
        /// </summary>
        public ref struct GCBulkRootStaticVarValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_GCRootID;
            private int _offset_ObjectID;
            private int _offset_TypeID;
            private int _offset_Flags;
            private int _offset_FieldName;
            private int _structSize;

            private int Offset_GCRootID
            {
                get
                {
                    if (_offset_GCRootID == -1)
                    {
                        _offset_GCRootID = _offset + 0;
                    }

                    return _offset_GCRootID;
                }
            }

            private int Offset_ObjectID
            {
                get
                {
                    if (_offset_ObjectID == -1)
                    {
                        _offset_ObjectID = Offset_GCRootID + 8;
                    }

                    return _offset_ObjectID;
                }
            }

            private int Offset_TypeID
            {
                get
                {
                    if (_offset_TypeID == -1)
                    {
                        _offset_TypeID = Offset_ObjectID + 8;
                    }

                    return _offset_TypeID;
                }
            }

            private int Offset_Flags
            {
                get
                {
                    if (_offset_Flags == -1)
                    {
                        _offset_Flags = Offset_TypeID + 8;
                    }

                    return _offset_Flags;
                }
            }

            private int Offset_FieldName
            {
                get
                {
                    if (_offset_FieldName == -1)
                    {
                        _offset_FieldName = Offset_Flags + 4;
                    }

                    return _offset_FieldName;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_FieldName + EtwEvent.UnicodeStringEnumerable.UnicodeStringEnumerator.StringLength(_etwEvent.Data, Offset_FieldName);
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the GCRootID field.
            /// </summary>
            public ulong GCRootID => BitConverter.ToUInt64(_etwEvent.Data[Offset_GCRootID..]);

            /// <summary>
            /// Retrieves the ObjectID field.
            /// </summary>
            public ulong ObjectID => BitConverter.ToUInt64(_etwEvent.Data[Offset_ObjectID..]);

            /// <summary>
            /// Retrieves the TypeID field.
            /// </summary>
            public ulong TypeID => BitConverter.ToUInt64(_etwEvent.Data[Offset_TypeID..]);

            /// <summary>
            /// Retrieves the Flags field.
            /// </summary>
            public GCRootStaticVarFlagsMap Flags => (GCRootStaticVarFlagsMap)BitConverter.ToUInt32(_etwEvent.Data[Offset_Flags..]);

            /// <summary>
            /// Retrieves the FieldName field.
            /// </summary>
            public string FieldName => System.Text.Encoding.Unicode.GetString(_etwEvent.Data[Offset_FieldName..]);

            /// <summary>
            /// Creates a new GCBulkRootStaticVarValue.
            /// </summary>
            public GCBulkRootStaticVarValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_GCRootID = -1;
                _offset_ObjectID = -1;
                _offset_TypeID = -1;
                _offset_Flags = -1;
                _offset_FieldName = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCBulkRootStaticVarValue structures.
        /// </summary>
        public ref struct GCBulkRootStaticVarValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCBulkRootStaticVarValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCBulkRootStaticVarValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCBulkRootStaticVarValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCBulkRootStaticVarValue collection.
            /// </summary>
            public ref struct GCBulkRootStaticVarValueEnumerator
            {
                private readonly GCBulkRootStaticVarValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCBulkRootStaticVarValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCBulkRootStaticVarValueEnumerator(GCBulkRootStaticVarValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }


        /// <summary>
        /// A data wrapper for a GCPerHeapHistoryValue structure.
        /// </summary>
        public ref struct GCPerHeapHistoryValue
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;

            private int _offset_SizeBefore;
            private int _offset_FreeListBefore;
            private int _offset_FreeObjBefore;
            private int _offset_SizeAfter;
            private int _offset_FreeListAfter;
            private int _offset_FreeObjAfter;
            private int _offset_In;
            private int _offset_PinnedSurv;
            private int _offset_NonePinnedSurv;
            private int _offset_NewAllocation;
            private int _structSize;

            private int Offset_SizeBefore
            {
                get
                {
                    if (_offset_SizeBefore == -1)
                    {
                        _offset_SizeBefore = _offset + 0;
                    }

                    return _offset_SizeBefore;
                }
            }

            private int Offset_FreeListBefore
            {
                get
                {
                    if (_offset_FreeListBefore == -1)
                    {
                        _offset_FreeListBefore = Offset_SizeBefore + _etwEvent.AddressSize;
                    }

                    return _offset_FreeListBefore;
                }
            }

            private int Offset_FreeObjBefore
            {
                get
                {
                    if (_offset_FreeObjBefore == -1)
                    {
                        _offset_FreeObjBefore = Offset_FreeListBefore + _etwEvent.AddressSize;
                    }

                    return _offset_FreeObjBefore;
                }
            }

            private int Offset_SizeAfter
            {
                get
                {
                    if (_offset_SizeAfter == -1)
                    {
                        _offset_SizeAfter = Offset_FreeObjBefore + _etwEvent.AddressSize;
                    }

                    return _offset_SizeAfter;
                }
            }

            private int Offset_FreeListAfter
            {
                get
                {
                    if (_offset_FreeListAfter == -1)
                    {
                        _offset_FreeListAfter = Offset_SizeAfter + _etwEvent.AddressSize;
                    }

                    return _offset_FreeListAfter;
                }
            }

            private int Offset_FreeObjAfter
            {
                get
                {
                    if (_offset_FreeObjAfter == -1)
                    {
                        _offset_FreeObjAfter = Offset_FreeListAfter + _etwEvent.AddressSize;
                    }

                    return _offset_FreeObjAfter;
                }
            }

            private int Offset_In
            {
                get
                {
                    if (_offset_In == -1)
                    {
                        _offset_In = Offset_FreeObjAfter + _etwEvent.AddressSize;
                    }

                    return _offset_In;
                }
            }

            private int Offset_PinnedSurv
            {
                get
                {
                    if (_offset_PinnedSurv == -1)
                    {
                        _offset_PinnedSurv = Offset_In + _etwEvent.AddressSize;
                    }

                    return _offset_PinnedSurv;
                }
            }

            private int Offset_NonePinnedSurv
            {
                get
                {
                    if (_offset_NonePinnedSurv == -1)
                    {
                        _offset_NonePinnedSurv = Offset_PinnedSurv + _etwEvent.AddressSize;
                    }

                    return _offset_NonePinnedSurv;
                }
            }

            private int Offset_NewAllocation
            {
                get
                {
                    if (_offset_NewAllocation == -1)
                    {
                        _offset_NewAllocation = Offset_NonePinnedSurv + _etwEvent.AddressSize;
                    }

                    return _offset_NewAllocation;
                }
            }

            /// <summary>
            /// Size of the structure.
            /// </summary>
            public int StructSize
            {
                get
                {
                    if (_structSize == -1)
                    {
                        _structSize = Offset_NewAllocation + _etwEvent.AddressSize;
                    }

                    return _structSize;
                }
            }

            /// <summary>
            /// Retrieves the SizeBefore field.
            /// </summary>
            public ulong SizeBefore => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_SizeBefore..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_SizeBefore..]);

            /// <summary>
            /// Retrieves the FreeListBefore field.
            /// </summary>
            public ulong FreeListBefore => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeListBefore..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeListBefore..]);

            /// <summary>
            /// Retrieves the FreeObjBefore field.
            /// </summary>
            public ulong FreeObjBefore => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeObjBefore..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeObjBefore..]);

            /// <summary>
            /// Retrieves the SizeAfter field.
            /// </summary>
            public ulong SizeAfter => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_SizeAfter..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_SizeAfter..]);

            /// <summary>
            /// Retrieves the FreeListAfter field.
            /// </summary>
            public ulong FreeListAfter => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeListAfter..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeListAfter..]);

            /// <summary>
            /// Retrieves the FreeObjAfter field.
            /// </summary>
            public ulong FreeObjAfter => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_FreeObjAfter..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_FreeObjAfter..]);

            /// <summary>
            /// Retrieves the In field.
            /// </summary>
            public ulong In => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_In..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_In..]);

            /// <summary>
            /// Retrieves the PinnedSurv field.
            /// </summary>
            public ulong PinnedSurv => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_PinnedSurv..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_PinnedSurv..]);

            /// <summary>
            /// Retrieves the NonePinnedSurv field.
            /// </summary>
            public ulong NonePinnedSurv => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NonePinnedSurv..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NonePinnedSurv..]);

            /// <summary>
            /// Retrieves the NewAllocation field.
            /// </summary>
            public ulong NewAllocation => _etwEvent.AddressSize == 4 ? BitConverter.ToUInt32(_etwEvent.Data[Offset_NewAllocation..]) : BitConverter.ToUInt64(_etwEvent.Data[Offset_NewAllocation..]);

            /// <summary>
            /// Creates a new GCPerHeapHistoryValue.
            /// </summary>
            public GCPerHeapHistoryValue(EtwEvent e, int offset)
            {
                _etwEvent = e;
                _offset = offset;
                _offset_SizeBefore = -1;
                _offset_FreeListBefore = -1;
                _offset_FreeObjBefore = -1;
                _offset_SizeAfter = -1;
                _offset_FreeListAfter = -1;
                _offset_FreeObjAfter = -1;
                _offset_In = -1;
                _offset_PinnedSurv = -1;
                _offset_NonePinnedSurv = -1;
                _offset_NewAllocation = -1;
                _structSize = -1;
            }
        }

        /// <summary>
        /// A structure that can enumerate GCPerHeapHistoryValue structures.
        /// </summary>
        public ref struct GCPerHeapHistoryValueEnumerable
        {
            private readonly EtwEvent _etwEvent;
            private readonly int _offset;
            private readonly uint _count;

            internal GCPerHeapHistoryValueEnumerable(EtwEvent e, int offset) :
                this(e, offset, uint.MaxValue)
            {
            }

            internal GCPerHeapHistoryValueEnumerable(EtwEvent e, int offset, uint count)
            {
                _etwEvent = e;
                _offset = offset;
                _count = count;
            }

            /// <summary>
            /// Gets an enumerator.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public GCPerHeapHistoryValueEnumerator GetEnumerator() => new(this);

            /// <summary>
            /// A structure that enumerates over an GCPerHeapHistoryValue collection.
            /// </summary>
            public ref struct GCPerHeapHistoryValueEnumerator
            {
                private readonly GCPerHeapHistoryValueEnumerable _enumerable;
                private int _offset;
                private int _index;

                /// <summary>
                /// The current value, if any.
                /// </summary>
                public GCPerHeapHistoryValue Current => ((_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count))
                    ? new(_enumerable._etwEvent, _offset)
                    : throw new InvalidOperationException();

                internal GCPerHeapHistoryValueEnumerator(GCPerHeapHistoryValueEnumerable enumerable)
                {
                    _enumerable = enumerable;
                    _offset = int.MaxValue;
                    _index = 0;
                }

                /// <summary>
                /// Moves to the next address.
                /// </summary>
                /// <returns>Whether there is another address.</returns>
                public bool MoveNext()
                {
                    if (_offset == int.MaxValue)
                    {
                        _offset = _enumerable._offset;
                        _index = 1;
                        return true;
                    }

                    _offset += Current.StructSize;
                    _index++;
                    return (_offset < _enumerable._etwEvent.Data.Length) && (_index <= _enumerable._count);
                }
            }
        }

    }
}