using FluentValidation.Results;

namespace Application.Exceptions
{
    public class ValidationExceptions : Exception
    {
        public List<string> Errors { get; }
        public ValidationExceptions() : base("Se han producido uno más errores de validación")
        {
            Errors = new List<string>();
        }
        public ValidationExceptions(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var item in failures)
            {
                Errors.Add(item.ErrorMessage);
            }
        }
    }
}
