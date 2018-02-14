/// <summary>
/// Finds the highest bin in histogram
/// </summary>
/// <param name="histogram">histogram with bins</param>
/// <returns> </returns>
public double OrientationAssignment(double[] histogram)
{
	// Defining the length
	int length = histogram.Length;

	// Sum from all index in histogram
	double sum = 0;

	// Creating new normalized array
	double[] normalizedHistogram = new double[length];

	// Counting the sum
	for (int i = 0; i < length; i++)
	{
		sum += histogram[i];
	}

	// Making the new normalized array
	for (int i = 0; i < length; i++)
	{
		normalizedHistogram[i] = histogram[i] / sum;
	}
	// Returning the max value
	return normalizedHistogram.Max();
}