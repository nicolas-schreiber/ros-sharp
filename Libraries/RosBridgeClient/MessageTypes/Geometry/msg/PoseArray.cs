/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using RosSharp.RosBridgeClient.MessageTypes.Std;

namespace RosSharp.RosBridgeClient.MessageTypes.Geometry
{
    public class PoseArray : Message
    {
        public override string RosMessageName => "geometry_msgs/PoseArray";

        //  An array of poses with a header for global reference.
        public Header header { get; set; }
        public Pose[] poses { get; set; }

        public PoseArray()
        {
            this.header = new Header();
            this.poses = new Pose[0];
        }

        public PoseArray(Header header, Pose[] poses)
        {
            this.header = header;
            this.poses = poses;
        }
    }
}
