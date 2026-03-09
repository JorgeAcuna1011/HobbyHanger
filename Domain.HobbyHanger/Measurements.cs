using Domain.HobbyHanger.Enums;

namespace Domain.HobbyHanger;

public class Measurements
{
    public string MeasurementsId { get; set; } = Guid.NewGuid().ToString();
    public LetterSize? LetterSize { get; set; }
    public int? WaistSize { get; set; }
    public int? InseamSize { get; set; }
    public MeasurementType MeasurementType { get; set; }
}