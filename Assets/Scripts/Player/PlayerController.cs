using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FirstOfUs.PlayerInput;

/* ZTK was here
 * MVC pattern ile basit bir oyun yapılmış.
 * Design patternler Bir programın planlanmasını ve/veya geliştirilmesini kolaylaştıran yöntemlerdir.
 * Ben de eskiden her projede data classları polymorphism vs gibi teknikleri yoğun bir şekilde kullanmaya çalışırdım.
 * Yüksek lisanstaki programlama hocamın söylediği çok güzel bir şey vardı..
 * "Bazen bir şeyi yapmanın en güzel yolu sadece yapmaktır."
 * 
 * Bu projede Çok fazla sistemin bir araya getirilip birbirine bağlandığını görüyorum.
 * Ancak bu kadar sistemi gerektirecek bir gameplay yok ne yazık ki.
 * Bu duruma biz "over engineering" diyoruz.
 * Tabi ki bir sistem ve yapı olacak ancak MVC sistemi biraz "overkill" olmuş.
 * Benzetme olarak ekmek kesmek için elektrikli testere kullanmaya çalışmak gibi :)
 * 
 * Developerlar mümkün olduğu kadar fazla çözüm yöntemi bilmelidir.
 * İyi developerlar bildiği yöntemleri programlarında kullanabilendir.
 * En iyi developerlar da bunları gerçekten gerekli yerlere uygulayandır.
 */
namespace FirstOfUs.Player
{
    public class PlayerController : Model
    {
        [SerializeField] private PlayerControllerData playerData;
        [SerializeField] private InputData inputData;

        //private Vector3 screenPoint;
        public float rotatePosY;
        public float rotateSpeed;

        protected override void Awake()
        {
            base.Awake();

            //screenPoint = UnityEngine.Camera.main.WorldToScreenPoint(transform.localPosition);
            rotateSpeed = playerData.RotateSpeed;
        }

        protected override void Start()
        {
            base.Start();
        }

        protected override void Update()
        {
            base.Update();
            if (inputData.isClickingRight || inputData.horizontalInput < 0f)
            {
                //sola dön
                rotatePosY += rotateSpeed * Time.deltaTime;
                transform.Rotate(0, rotatePosY, 0);
            }
            else if (inputData.isClickingLeft || inputData.horizontalInput > 0f)
            {
                //saða dön
                rotatePosY += rotateSpeed * Time.deltaTime;
                transform.Rotate(0, -rotatePosY, 0);
            }
            else
            {
                rotatePosY = 0f;
            }
        }
    }

}