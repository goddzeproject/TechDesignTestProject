using System.Collections;
using UnityEngine;

namespace CodeBase
{
    public class FadeInOutAuto : MonoBehaviour
    {
        public float minAlpha = 0f;
        public float maxAlpha = 1f;
        public float Duration = 1f;
        
        private SpriteRenderer spriteRenderer;
        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

            StartCoroutine(FadeInAndOutRoutine());
        }

        private IEnumerator FadeInAndOutRoutine()
        {
            while (true)
            {
                for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
                {
                    Color newColor = spriteRenderer.color;
                    newColor.a = Mathf.Lerp(minAlpha, maxAlpha, t);
                    spriteRenderer.color = newColor;
                
                    yield return null;
                }
                yield return new WaitForSeconds(Duration);

                for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
                {
                    Color newColor = spriteRenderer.color;
                    newColor.a = Mathf.Lerp(maxAlpha, minAlpha, t);
                    spriteRenderer.color = newColor;
                
                    yield return null;
                }
                yield return new WaitForSeconds(Duration);
            }
        }
    }
}