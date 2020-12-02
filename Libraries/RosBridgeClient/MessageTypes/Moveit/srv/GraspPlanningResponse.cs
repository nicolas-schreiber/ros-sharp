/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */



namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class GraspPlanningResponse : Message
    {
        public override string RosMessageName => "moveit_msgs/GraspPlanning";

        //  the list of planned grasps
        public Grasp[] grasps { get; set; }
        //  whether an error occurred
        public MoveItErrorCodes error_code { get; set; }

        public GraspPlanningResponse()
        {
            this.grasps = new Grasp[0];
            this.error_code = new MoveItErrorCodes();
        }

        public GraspPlanningResponse(Grasp[] grasps, MoveItErrorCodes error_code)
        {
            this.grasps = grasps;
            this.error_code = error_code;
        }
    }
}
