using System;

public class SmartDevice
{
    public string DeviceName { get; set; }
    public bool IsOn { get; set; }

    public virtual void TurnOn() { }
    public virtual void TurnOff() { }
}

// Класс для лампочек ghbhf
public class SmartLight : SmartDevice
{
    public int Brightness { get; set; }

    public void AdjustBrightness(int level)
    {
        Brightness = level;
    }

    public override void TurnOn()
    {
        IsOn = true;
    }

    public override void TurnOff()
    {
        IsOn = false;
    }
}

// Класс для термостата
public class SmartThermostat : SmartDevice
{
    public int Temperature { get; private set; }

    public void SetTemperature(int temperature)
    {
        Temperature = temperature;
    }

    public override void TurnOn()
    {
        IsOn = true;
    }

    public override void TurnOff()
    {
        IsOn = false;
    }
}