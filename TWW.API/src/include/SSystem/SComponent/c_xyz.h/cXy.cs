//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class cXy {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public f32 x {get => this._x(); set => this._x(value);}//;
        
        public f32 y {get => this._y(); set => this._y(value);}//;
        
        public cXy(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private f32 _x() {
            return Memory.RAM.ReadF32(this.pointer + 0x0); // DEADBEEF TODO: Fix Addr
        }
        
        private void _x(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0, value);// DEADBEEF TODO: Fix Addr
        }
        
        private f32 _y() {
            return Memory.RAM.ReadF32(this.pointer + 0x0); // DEADBEEF TODO: Fix Addr
        }
        
        private void _y(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0, value);// DEADBEEF TODO: Fix Addr
        }
    }
}