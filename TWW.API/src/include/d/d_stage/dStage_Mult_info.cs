//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class dStage_Mult_info {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public f32 mTransX {get => this._mTransX(); set => this._mTransX(value);}//;
        
        public f32 mTransY {get => this._mTransY(); set => this._mTransY(value);}//;
        
        public s16 mAngle {get => this._mAngle(); set => this._mAngle(value);}//;
        
        public u8 mRoomNo {get => this._mRoomNo(); set => this._mRoomNo(value);}//;
        
        public u8 mWaveMax {get => this._mWaveMax(); set => this._mWaveMax(value);}//;
        
        public dStage_Mult_info(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0xC;
        }
        
        private f32 _mTransX() {
            return Memory.RAM.ReadF32(this.pointer + 0x0);
        }
        
        private void _mTransX(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0, value);
        }
        
        private f32 _mTransY() {
            return Memory.RAM.ReadF32(this.pointer + 0x4);
        }
        
        private void _mTransY(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x4, value);
        }
        
        private s16 _mAngle() {
            return Memory.RAM.ReadS16(this.pointer + 0x8);
        }
        
        private void _mAngle(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x8, value);
        }
        
        private u8 _mRoomNo() {
            return Memory.RAM.ReadU8(this.pointer + 0xA);
        }
        
        private void _mRoomNo(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0xA, value);
        }
        
        private u8 _mWaveMax() {
            return Memory.RAM.ReadU8(this.pointer + 0xB);
        }
        
        private void _mWaveMax(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0xB, value);
        }
    }
}
