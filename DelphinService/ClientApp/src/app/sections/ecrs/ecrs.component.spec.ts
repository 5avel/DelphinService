import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EcrsComponent } from './ecrs.component';

describe('EcrsComponent', () => {
  let component: EcrsComponent;
  let fixture: ComponentFixture<EcrsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EcrsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EcrsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
