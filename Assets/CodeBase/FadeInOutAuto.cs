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

        // Start is called before the first frame update
        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

            StartCoroutine(FadeInAndOutRoutine());
        }

        private IEnumerator FadeInAndOutRoutine()
        {
            while (true)
            {
                // Плавное появление
                for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
                {
                    Color newColor = spriteRenderer.color;
                    newColor.a = Mathf.Lerp(minAlpha, maxAlpha, t);
                    spriteRenderer.color = newColor;
                
                    yield return null;
                }
                // Пауза перед исчезновением
                yield return new WaitForSeconds(Duration);
                // Плавное исчезновение
                for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / 2.0f)
                {
                    Color newColor = spriteRenderer.color;
                    newColor.a = Mathf.Lerp(maxAlpha, minAlpha, t);
                    spriteRenderer.color = newColor;
                
                    yield return null;
                }
                // Пауза перед следующим появлением
                yield return new WaitForSeconds(Duration);
            }
        }
    }
}