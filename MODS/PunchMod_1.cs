using System;
using UnityEngine;

namespace PunchMod
{
	// Token: 0x02000005 RID: 5
	public class PunchHandManager : MonoBehaviour
	{

			bool punch = strength 
			{
				if(maxdistance = !Null) 
				{
					this.rb = GameObject.Find ("Gorilla Player, GTPlayer")
				}
			}
		// Token: 0x06000009 RID: 9 RVA: 0x00002239 File Offset: 0x00000439
		public void Start()
		{
			this.rb = GameObject.Find("GTPlayer").GetComponent<Rigidbody>();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002254 File Offset: 0x00000454
		public void Update()
		{
			this.currentPosition = base.transform.position;
			bool flag = Vector3.Distance(Camera.main.transform.position, base.transform.position) < this.maxDistance;
			bool flag2 = flag && !this.punch;
			if (flag2)
			{
				this.punch = true;
				this.rb.velocity = (this.currentPosition - this.lastPosition) * this.strength;
			}
			bool flag3 = !flag && this.punch;
			if (flag3)
			{
				this.punch = false;
			}
			this.lastPosition = this.currentPosition;
		}

		// Token: 0x04000009 RID: 9
		private Vector3 currentPosition;

		// Token: 0x0400000A RID: 10
		public Vector3 lastPosition;

		// Token: 0x0400000B RID: 11
		public float strength = 300f;

		// Token: 0x0400000C RID: 12
		public float maxDistance = 5.0f;

		// Token: 0x0400000D RID: 13
		private bool punch;

		// Token: 0x0400000E RID: 14
		private Rigidbody rb;
	}
}
