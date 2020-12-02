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
    public class InertiaStamped : Message
    {
        public override string RosMessageName => "geometry_msgs/InertiaStamped";

        public Header header { get; set; }
        public Inertia inertia { get; set; }

        public InertiaStamped()
        {
            this.header = new Header();
            this.inertia = new Inertia();
        }

        public InertiaStamped(Header header, Inertia inertia)
        {
            this.header = header;
            this.inertia = inertia;
        }
    }
}
