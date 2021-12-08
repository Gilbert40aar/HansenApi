import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatesettingsComponent } from './createsettings.component';

describe('CreatesettingsComponent', () => {
  let component: CreatesettingsComponent;
  let fixture: ComponentFixture<CreatesettingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreatesettingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatesettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
