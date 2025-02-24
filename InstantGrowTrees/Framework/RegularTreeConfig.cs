namespace InstantGrowTrees.Framework;

/// <summary>The mod configuration for non-fruit trees.</summary>
internal class RegularTreeConfig
{
    /// <summary>Whether trees should grow instantly overnight.</summary>
    public bool InstantlyGrow { get; set; } = true;

    /// <summary>Whether trees should grow instantly in winter (if <see cref="InstantlyGrow"/> is also true).</summary>
    public bool InstantlyGrowInWinter { get; set; } = true;

    /// <summary>Whether trees should grow instantly even if they'd normally not grow (e.g. too close to another tree).</summary>
    public bool InstantlyGrowWhenInvalid { get; set; } = false;
}
