using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointData
	{
		public int Point;
	}
public class PointSaveLoader : SaveLoader<PointData, PointStorage>
{
    protected override PointData ConvertToData(PointStorage service)
    {
        return new PointData()
		{
			Point = service.GetValue()
		};
    }

    protected override void SetupData(PointData data, PointStorage service)
    {
        throw new NotImplementedException();
    }
}