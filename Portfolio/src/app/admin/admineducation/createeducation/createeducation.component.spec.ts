import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateeducationComponent } from './createeducation.component';

describe('CreateeducationComponent', () => {
  let component: CreateeducationComponent;
  let fixture: ComponentFixture<CreateeducationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateeducationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateeducationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
