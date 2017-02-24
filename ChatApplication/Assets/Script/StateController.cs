using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace chat{
	public class StateController : MonoBehaviour {
	
		//スレッドのクローン元
		[SerializeField]private GameObject GuildClone;
		[SerializeField]private GameObject RoomClone;
		[SerializeField]private GameObject PrivateClone;
	
		//クローンを行う先のオブジェクト
		[SerializeField]private GameObject GuildParent;
		[SerializeField]private GameObject RoomParent;
		[SerializeField]private GameObject PrivateParent;
	
		//
	
		// Use this for initialization
		void Start () {
			int i;
			for (i = 0 ; i < 5 ; i++)
			{
				var obj_guild = Instantiate (GuildClone);
				obj_guild.transform.parent = GuildParent.transform;
				obj_guild.transform.localScale = Vector3.one;
				obj_guild.SetActive (true);

		
			}
		}

		// Update is called once per frame
		void Update () {
		
		}
	}
} 