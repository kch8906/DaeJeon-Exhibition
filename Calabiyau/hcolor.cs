using UnityEngine;
using System.Collections;


public class hcolor : MonoBehaviour {


	public Color color1 = Color.red;
	public Color color2 = Color.green;
	public Color color3 = Color.yellow;
	public Color color4 = Color.magenta;
	public Color color5 = Color.yellow;
	public Color color6 = Color.magenta;
	public Color color7 = Color.yellow;
	public Color color8 = Color.magenta;
	public Color color9 = Color.yellow;
	public Color color10 = Color.magenta;
	public Color color11 = Color.black;
	public Color color12 = Color.cyan;

	public float duration = 7.0F;
	public Renderer rend;
	public int Count = 0;



	void Start() {


		rend = GetComponent<Renderer> ();



	}
	void Update() {


		//	if (Count >= 0) {
				float lerp = Mathf.PingPong (Time.time, duration) / duration;
				rend.material.color = Color.Lerp (color1, color2, lerp);
				//Count++;

			/*	if (Count > 350) {

					float lerp1 = Mathf.PingPong (Time.time, duration) / duration;
					rend.material.color = Color.Lerp (color3, color4, lerp1);
					//	Count++;



					if (Count >= 700) {
						float lerp2 = Mathf.PingPong (Time.time, duration) / duration;
						rend.material.color = Color.Lerp (color5, color6, lerp2);
						//Count++;



						if (Count >= 1050) {

							float lerp3 = Mathf.PingPong (Time.time, duration) / duration;
							rend.material.color = Color.Lerp (color7, color8, lerp3);
							//Count++;



							if (Count >= 1400) {

								float lerp4 = Mathf.PingPong (Time.time, duration) / duration;
								rend.material.color = Color.Lerp (color9, color10, lerp4);
								//	Count++;



								if (Count >= 1750) {

									float lerp5 = Mathf.PingPong (Time.time, duration) / duration;
									rend.material.color = Color.Lerp (color11, color12, lerp5);
									//Count++;


									if (Count >= 2250) {


										Count = 0;


									}

			    
								}

							}
						}
										
					}

				}*/
			}
		
	}



	