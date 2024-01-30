using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buffer = NodeBuffer.Buffer;

namespace WW.API
{
    public class daPy_py_c : fopAc_ac_c
    {
        public u32 pointer;

        public daPy_py_c(u32 pointer) : base(pointer)
        {
            this.pointer = pointer;
        }

        /* 0x290 */
        public u8 mCutType;
        /* 0x291 */
        public u8 mCutCount;
        /* 0x292 #ARRCOUNT 2 */
        public Buffer field_0x292;
        /* 0x294 */
        public s16 mDamageWaitTimer;
        /* 0x296 */
        public s16 mQuakeTimer;
        /* 0x298 */
        public int mFace;
        /* 0x29C */
        public u32 mNoResetFlg0;
        /* 0x2A0 */
        public u32 mNoResetFlg1;
        /* 0x2A4 */
        public u32 mResetFlg0;
        /* 0x2A8 */
        public f32 field_0x2a8;
        /* 0x2AC */
        public f32 mHeight;
        /* 0x2B0 */
        public f32 field_0x2b0;
        /* 0x2B4 */
        public csXyz mBodyAngle;
        /* 0x2BA #ARRCOUNT 2 */
        public Buffer field_0x2BA;
        /* 0x2BC */
        public cXyz mHeadTopPos;
        /* 0x2C8 */
        public cXyz mSwordTopPos;
        /* 0x2D4 */
        public cXyz mLeftHandPos;
        /* 0x2E0 */
        public cXyz mRightHandPos;
        /* 0x2EC */
        public cXyz mRopePos;
        /* 0x2F8 */
        public cXyz field_0x2f8;
        /* 0x304 */
        //public daPy_demo_c mDemo;

    }
}
