using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLibrary;
using MonoGameLibrary.Graphics;

namespace LaTaleDoujin;

public class Game1 : Core
{
    private AnimatedSprite _zoeNPC;
    private AnimatedSprite _zoeMobAnim1;
    private AnimatedSprite _zoeMobAnim2;
    private AnimatedSprite _zoeMobAnim3;
    private AnimatedSprite _zoeMobAnim4;
    private AnimatedSprite _zoeMobAnim5;
    private AnimatedSprite _zoeMobAnim6;
    private AnimatedSprite _zoeMobAnim7;
    private AnimatedSprite _zoeMobAnim8;
    private AnimatedSprite _zoeMobAnim9;
    private AnimatedSprite _zoeMobAnim10;
    private AnimatedSprite _zoeMobAnim11;
    private AnimatedSprite _zoeMobAnim12;
    private AnimatedSprite _zoeMobAnim13;
    private AnimatedSprite _zoeMobAnim14;
    private AnimatedSprite _zoeMob2Anim1;
    private AnimatedSprite _zoeMob2Anim2;
    private AnimatedSprite _zoeMob2Anim3;
    private AnimatedSprite _zoeMob2Anim4;

    public Game1() : base("La Tale Doujin", 1280, 720, false)
    {

    }

    protected override void Initialize()
    {
        base.Initialize();

    }

    protected override void LoadContent()
    {
        TextureAtlas zoeAtlas = TextureAtlas.FromFile(Content, "images/zoe-definition.xml");
        _zoeNPC = zoeAtlas.CreateAnimatedSprite("zoe-npc-animation");

        TextureAtlas zoeAtlas2 = TextureAtlas.FromFile(Content, "images/zoe-mob-definition.xml");
        _zoeMobAnim1 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim1");
        _zoeMobAnim2 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim2");
        _zoeMobAnim3 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim3");
        _zoeMobAnim4 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim4");
        _zoeMobAnim5 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim5");
        _zoeMobAnim6 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim6");
        _zoeMobAnim7 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim7");
        _zoeMobAnim8 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim8");
        _zoeMobAnim9 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim9");
        _zoeMobAnim10 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim10");
        _zoeMobAnim11 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim11");
        _zoeMobAnim12 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim12");
        _zoeMobAnim13 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim13");
        _zoeMobAnim14 = zoeAtlas2.CreateAnimatedSprite("zoe-mob-anim14");

        TextureAtlas zoeAtlas3 = TextureAtlas.FromFile(Content, "images/zoe-mob-definition2.xml");
        _zoeMob2Anim1 = zoeAtlas3.CreateAnimatedSprite("zoe-mob2-anim1");
        _zoeMob2Anim2 = zoeAtlas3.CreateAnimatedSprite("zoe-mob2-anim2");
        _zoeMob2Anim3 = zoeAtlas3.CreateAnimatedSprite("zoe-mob2-anim3");
        _zoeMob2Anim4 = zoeAtlas3.CreateAnimatedSprite("zoe-mob2-anim4");
    }

    protected override void Update(GameTime gameTime)
    {
        _zoeNPC.Update(gameTime);
        _zoeMobAnim1.Update(gameTime);
        _zoeMobAnim2.Update(gameTime);
        _zoeMobAnim3.Update(gameTime);
        _zoeMobAnim4.Update(gameTime);
        _zoeMobAnim5.Update(gameTime);
        _zoeMobAnim6.Update(gameTime);
        _zoeMobAnim7.Update(gameTime);
        _zoeMobAnim8.Update(gameTime);
        _zoeMobAnim9.Update(gameTime);
        _zoeMobAnim10.Update(gameTime);
        _zoeMobAnim11.Update(gameTime);
        _zoeMobAnim12.Update(gameTime);
        _zoeMobAnim13.Update(gameTime);
        _zoeMobAnim14.Update(gameTime);
        _zoeMob2Anim1.Update(gameTime);
        _zoeMob2Anim2.Update(gameTime);
        _zoeMob2Anim3.Update(gameTime);
        _zoeMob2Anim4.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        // Clear the back buffer.
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Begin the sprite batch to prepare for rendering.
        SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        _zoeNPC.Draw(SpriteBatch, new Vector2(100, 100));
        _zoeMobAnim1.Draw(SpriteBatch, new Vector2(200, 100));
        _zoeMobAnim2.Draw(SpriteBatch, new Vector2(300, 100));
        _zoeMobAnim3.Draw(SpriteBatch, new Vector2(400, 100));
        _zoeMobAnim4.Draw(SpriteBatch, new Vector2(500, 100));
        _zoeMobAnim5.Draw(SpriteBatch, new Vector2(600, 100));
        _zoeMobAnim6.Draw(SpriteBatch, new Vector2(700, 100));
        _zoeMobAnim7.Draw(SpriteBatch, new Vector2(800, 100));
        _zoeMobAnim8.Draw(SpriteBatch, new Vector2(900, 100));
        _zoeMobAnim9.Draw(SpriteBatch, new Vector2(1000, 100));
        _zoeMobAnim10.Draw(SpriteBatch, new Vector2(100, 300));
        _zoeMobAnim11.Draw(SpriteBatch, new Vector2(200, 300));
        _zoeMobAnim12.Draw(SpriteBatch, new Vector2(300, 300));
        _zoeMobAnim13.Draw(SpriteBatch, new Vector2(400, 300));
        _zoeMobAnim14.Draw(SpriteBatch, new Vector2(500, 300));
        _zoeMob2Anim1.Draw(SpriteBatch, new Vector2(700, 300));
        _zoeMob2Anim2.Draw(SpriteBatch, new Vector2(800, 300));
        _zoeMob2Anim3.Draw(SpriteBatch, new Vector2(900, 300));
        _zoeMob2Anim4.Draw(SpriteBatch, new Vector2(1000, 300));

        // Always end the sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}