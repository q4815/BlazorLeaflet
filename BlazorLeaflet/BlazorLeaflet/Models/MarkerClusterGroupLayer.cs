using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorLeaflet.Models
{
    public class MarkerClusterGroupLayer : InteractiveLayer
    {
        public List<Marker> Marker { get; set; }
        public string JsIconCreateFunctionName { get; set; }
    }
}
