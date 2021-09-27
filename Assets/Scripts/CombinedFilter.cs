public class CombinedFilter
{
  public static int[] combinedFilter(int[] xs)
  {
    return FactFilter.facts(DiffFilter.diffs(xs));
  }
}
