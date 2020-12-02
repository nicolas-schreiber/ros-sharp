/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int64 : Message
    {
        public override string RosMessageName => "std_msgs/Int64";

        public long data { get; set; }

        public Int64()
        {
            this.data = 0;
        }

        public Int64(long data)
        {
            this.data = data;
        }
    }
}
