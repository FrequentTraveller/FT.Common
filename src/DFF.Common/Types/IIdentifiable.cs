using System;

namespace DFF.Common.Types
{
    public interface IIdentifiable
    {
        Guid Id { get; }
        bool Deleted { get; }
    }
}