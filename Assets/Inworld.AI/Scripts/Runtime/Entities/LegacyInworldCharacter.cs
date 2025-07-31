using Inworld;

namespace Inworld.Entities
{
    /// <summary>
    /// Temporary compatibility wrapper so scripts that still reference
    /// Inworld.Entities.InworldCharacter continue to compile.
    /// </summary>
    public class InworldCharacter : global::Inworld.InworldCharacter
    {
        // No additional implementation – inherits everything from the new namespace.
    }
}
