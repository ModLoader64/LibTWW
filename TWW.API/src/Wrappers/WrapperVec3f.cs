//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class WrapperVec3f {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public f32 x {get => this._x(); set => this._x(value);}//;
        
        public f32 y {get => this._y(); set => this._y(value);}//;
        
        public f32 z {get => this._z(); set => this._z(value);}//;
        
        public WrapperVec3f(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0C;
        }
        
        private f32 _x() {
            return Memory.RAM.ReadF32(this.pointer + 0x00);
        }
        
        private void _x(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x00, value);
        }
        
        private f32 _y() {
            return Memory.RAM.ReadF32(this.pointer + 0x04);
        }
        
        private void _y(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x04, value);
        }
        
        private f32 _z() {
            return Memory.RAM.ReadF32(this.pointer + 0x08);
        }
        
        private void _z(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x08, value);
        }
    }
}
