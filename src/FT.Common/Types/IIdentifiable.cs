using System;

namespace FT.Common.Types
{
    public interface IIdentifiable
    {
        Guid Id { get; }
        bool Deleted { get; }
    }
}