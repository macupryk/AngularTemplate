import { AngularProjectTemplatePage } from './app.po';

describe('AngularProject App', function() {
  let page: AngularProjectTemplatePage;

  beforeEach(() => {
    page = new AngularProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
