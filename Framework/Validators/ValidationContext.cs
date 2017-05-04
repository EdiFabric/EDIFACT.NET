using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Validators
{
    class ValidationContext
    {
        public object Instance { get; set; }
        public SegmentErrorContext ErrorContext { get; set; }

        public ValidationContext(object instance, SegmentErrorContext errorContext)
        {
            Instance = instance;
            ErrorContext = errorContext;
        }
    }
}
