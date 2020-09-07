using devitemapi.Dto;

namespace devitemapi.Infrastructure.Log
{
    public interface IApiLogger
    {
        public void Trace(LogDto log);

        public void Debug(LogDto log);

        public void Info(LogDto log);

        public void Warnnig(LogDto log);

        public void Error(LogDto log);
    }
}