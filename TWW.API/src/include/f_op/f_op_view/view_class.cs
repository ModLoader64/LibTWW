//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TWW.API {
    
    
    public class view_class {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        //public leafdraw_method_class mSubMtd {get => this._mSubMtd(); set => this._mSubMtd(value);}//;
        
        public u8 field_0xc4 {get => this._field_0xc4(); set => this._field_0xc4(value);}//;
        
        public f32 mNear {get => this._mNear(); set => this._mNear(value);}//;
        
        public f32 mFar {get => this._mFar(); set => this._mFar(value);}//;
        
        public f32 mFovy {get => this._mFovy(); set => this._mFovy(value);}//;
        
        public f32 mAspect {get => this._mAspect(); set => this._mAspect(value);}//;
        
        public lookat_class mLookat {get => this._mLookat(); set => this._mLookat(value);}//;
        
        public s16 mBank {get => this._mBank(); set => this._mBank(value);}//;
        
/*        public Mtx44 mProjMtx {get => this._mProjMtx(); set => this._mProjMtx(value);}//;
        
        public Mtx mViewMtx {get => this._mViewMtx(); set => this._mViewMtx(value);}//;
        
        public Mtx mInvViewMtx {get => this._mInvViewMtx(); set => this._mInvViewMtx(value);}//;
        
        public Mtx44 mProjViewMtx {get => this._mProjViewMtx(); set => this._mProjViewMtx(value);}//;
        
        public Mtx mViewMtxNoTrans {get => this._mViewMtxNoTrans(); set => this._mViewMtxNoTrans(value);}//;*/
        
        public view_class(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0; // DEADBEEF TODO: Fix Addr
        }
        
/*        private leafdraw_method_class _mSubMtd() {
            return new leafdraw_method_class(this.pointer + 0x0C0);
        }
        
        private void _mSubMtd(leafdraw_method_class value) {
        }*/
        
        private u8 _field_0xc4() {
            return Memory.RAM.ReadU8(this.pointer + 0x0C4);
        }
        
        private void _field_0xc4(u8 value) {
            Memory.RAM.WriteU8(this.pointer + 0x0C4, value);
        }
        
        private f32 _mNear() {
            return Memory.RAM.ReadF32(this.pointer + 0x0C8);
        }
        
        private void _mNear(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0C8, value);
        }
        
        private f32 _mFar() {
            return Memory.RAM.ReadF32(this.pointer + 0x0CC);
        }
        
        private void _mFar(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0CC, value);
        }
        
        private f32 _mFovy() {
            return Memory.RAM.ReadF32(this.pointer + 0x0D0);
        }
        
        private void _mFovy(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0D0, value);
        }
        
        private f32 _mAspect() {
            return Memory.RAM.ReadF32(this.pointer + 0x0D4);
        }
        
        private void _mAspect(f32 value) {
            Memory.RAM.WriteF32(this.pointer + 0x0D4, value);
        }
        
        private lookat_class _mLookat() {
            return new lookat_class(this.pointer + 0x0D8);
        }
        
        private void _mLookat(lookat_class value) {
        }
        
        private s16 _mBank() {
            return Memory.RAM.ReadS16(this.pointer + 0x0FC);
        }
        
        private void _mBank(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x0FC, value);
        }
        
        /*private Mtx44 _mProjMtx() {
            return new Mtx44(this.pointer + 0x100);
        }
        
        private void _mProjMtx(Mtx44 value) {
        }
        
        private Mtx _mViewMtx() {
            return new Mtx(this.pointer + 0x140);
        }
        
        private void _mViewMtx(Mtx value) {
        }
        
        private Mtx _mInvViewMtx() {
            return new Mtx(this.pointer + 0x170);
        }
        
        private void _mInvViewMtx(Mtx value) {
        }
        
        private Mtx44 _mProjViewMtx() {
            return new Mtx44(this.pointer + 0x1A0);
        }
        
        private void _mProjViewMtx(Mtx44 value) {
        }
        
        private Mtx _mViewMtxNoTrans() {
            return new Mtx(this.pointer + 0x1E0);
        }
        
        private void _mViewMtxNoTrans(Mtx value) {
        }*/
    }
}