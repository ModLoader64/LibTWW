//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class view_port_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public f32 mXOrig {get => this._mXOrig(); set => this._mXOrig(value);}//;
        
        public f32 mYOrig {get => this._mYOrig(); set => this._mYOrig(value);}//;
        
        public f32 mWidth {get => this._mWidth(); set => this._mWidth(value);}//;
        
        public f32 mHeight {get => this._mHeight(); set => this._mHeight(value);}//;
        
        public f32 mNearZ {get => this._mNearZ(); set => this._mNearZ(value);}//;
        
        public f32 mFarZ {get => this._mFarZ(); set => this._mFarZ(value);}//;
        
        public scissor_class mScissor {get => this._mScissor(); set => this._mScissor(value);}//;
        
        public view_port_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
        private f32 _mXOrig() {
            return Memory.RAM.ReadF32(this.pointer + 0x00);
        }
        
        private void _mXOrig(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x00, value);
        }
        
        private f32 _mYOrig() {
            return Memory.RAM.ReadF32(this.pointer + 0x04);
        }
        
        private void _mYOrig(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x04, value);
        }
        
        private f32 _mWidth() {
            return Memory.RAM.ReadF32(this.pointer + 0x08);
        }
        
        private void _mWidth(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x08, value);
        }
        
        private f32 _mHeight() {
            return Memory.RAM.ReadF32(this.pointer + 0x0C);
        }
        
        private void _mHeight(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0C, value);
        }
        
        private f32 _mNearZ() {
            return Memory.RAM.ReadF32(this.pointer + 0x10);
        }
        
        private void _mNearZ(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x10, value);
        }
        
        private f32 _mFarZ() {
            return Memory.RAM.ReadF32(this.pointer + 0x14);
        }
        
        private void _mFarZ(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x14, value);
        }
        
        private scissor_class _mScissor() {
            return new scissor_class(this.pointer + 0x18);
        }
        
        private void _mScissor(scissor_class value) {
        }
    }
}
